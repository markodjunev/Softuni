namespace MXGP.Core
{
    using System;
    using System.Text;
    using System.Linq;
    using MXGP.Models.Motorcycles.Contracts;
    using MXGP.Models.Races.Contracts;
    using MXGP.Models.Riders;
    using MXGP.Utilities.Messages;
    using MXGP.Core.Contracts;
    using MXGP.Models.Riders.Contracts;
    using MXGP.Repositories;
    using MXGP.Repositories.Contracts;
    using MXGP.Models.Motorcycles;
    using MXGP.Models.Races;

    public class ChampionshipController : IChampionshipController
    {
        private readonly IRepository<IRider> ridersRepository;
        private readonly IRepository<IMotorcycle> motorcyclesRepository;
        private readonly IRepository<IRace> raceRepository;

        public ChampionshipController()
        {
            this.ridersRepository = new RiderRepository();
            this.motorcyclesRepository = new MotorcycleRepository();
            this.raceRepository = new RaceRepository();
        }

        public string CreateRider(string riderName)
        {
            var rider = this.ridersRepository.GetByName(riderName);
            if (rider != null)
            {
                throw new ArgumentException($"Rider {riderName} is already created.");
            }

            rider = new Rider(riderName);
            this.ridersRepository.Add(rider);
            return $"Rider {riderName} is created.";
        }

        public string CreateMotorcycle(string type, string model, int horsePower)
        {
            IMotorcycle motorcycle = this.motorcyclesRepository.GetByName(model);

            if (motorcycle != null)
            {
                throw new ArgumentException($"Motorcycle {model} is already created.");
            }

            switch (type)
            {
                case "Speed":
                    motorcycle = new SpeedMotorcycle(model, horsePower);
                    break;
                case "Power":
                    motorcycle = new PowerMotorcycle(model, horsePower);
                    break;
            }

            this.motorcyclesRepository.Add(motorcycle);
            return $"{motorcycle.GetType().Name} {motorcycle.Model} is created";
        }

        public string CreateRace(string name, int laps)
        {
            var race = this.raceRepository.GetByName(name);
            if (race != null)
            {
                throw new InvalidOperationException($"Race {name} is already created.");
            }

            race = new Race(name, laps);
            this.raceRepository.Add(race);
            return $"Race {name} is created.";
        }

        public string AddRiderToRace(string raceName, string riderName)
        {
            var race = this.raceRepository.GetByName(raceName);
            var rider = this.ridersRepository.GetByName(riderName);

            if (race == null)
            {
                throw new InvalidOperationException($"Race {raceName} could not be found.");
            }

            if (rider == null)
            {
                throw new InvalidOperationException($"Rider {riderName} could not be found.");
            }

            race.AddRider(rider);
            return $"Rider {riderName} added in {raceName} race.";
        }

        public string AddMotorcycleToRider(string riderName, string motorcycleModel)
        {
            var rider = this.ridersRepository.GetByName(riderName);
            var motorcycle = this.motorcyclesRepository.GetByName(motorcycleModel);

            if (rider == null)
            {
                throw new InvalidOperationException($"Rider {riderName} could not be found.");
            }

            if (motorcycle == null)
            {
                throw new InvalidOperationException($"Motorcycle {motorcycleModel} could not be found.");
            }

            rider.AddMotorcycle(motorcycle);
            return $"Rider {riderName} received motorcycle {motorcycleModel}.";
        }

        public string StartRace(string raceName)
        {
            var race = this.raceRepository.GetByName(raceName);

            if (race == null)
            {
                throw new InvalidOperationException($"Race {raceName} could not be found.");
            }

            if (race.Riders.Count < 3)
            {
                throw new InvalidOperationException($"Race {raceName} cannot start with less than 3 participants.");
            }

            var riders = race.Riders.OrderByDescending(x => x.Motorcycle.CalculateRacePoints(race.Laps))
                .Take(3)
                .ToList();
            var sb = new StringBuilder();

            sb.AppendLine($"Rider {riders[0].Name} wins {raceName} race.");
            sb.AppendLine($"Rider {riders[1].Name} is second in {raceName} race.");
            sb.AppendLine($"Rider {riders[2].Name} is third in {raceName} race.");

            raceRepository.Remove(race);
            return sb.ToString().TrimEnd();
        }
    }
}