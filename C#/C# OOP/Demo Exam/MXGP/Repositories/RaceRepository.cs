namespace MXGP.Repositories
{
    using System.Collections.Generic;
    using MXGP.Models.Races.Contracts;
    using MXGP.Repositories.Contracts;
    using System.Linq;

    public class RaceRepository : IRepository<IRace>
    {
        private readonly IList<IRace> races;

        public IRace GetByName(string name)
        {
            IRace race = this.races
                .FirstOrDefault(r => r.Name == name);

            return race;
        }

        public IReadOnlyCollection<IRace> GetAll() => this.races.ToList();

        public void Add(IRace model)
        {
            races.Add(model);
        }

        public bool Remove(IRace model)
        {
            return this.races.Remove(model);
        }
    }
}