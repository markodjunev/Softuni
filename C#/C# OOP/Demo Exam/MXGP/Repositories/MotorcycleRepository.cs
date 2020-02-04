namespace MXGP.Repositories
{
    using System.Collections.Generic;
    using System.Linq;
    using MXGP.Models.Motorcycles.Contracts;
    using MXGP.Repositories.Contracts;

    public class MotorcycleRepository : IRepository<IMotorcycle>
    {
        private readonly IList<IMotorcycle> motorcycles;

        public MotorcycleRepository()
        {
            this.motorcycles = new List<IMotorcycle>();
        }

        public IMotorcycle GetByName(string name)
        {
            IMotorcycle motorcycle = this.motorcycles
                .FirstOrDefault(m => m.Model == name);

            return motorcycle;
        }

        public IReadOnlyCollection<IMotorcycle> GetAll() => this.motorcycles.ToList();

        public void Add(IMotorcycle model)
        {
            this.motorcycles.Add(model);
        }

        public bool Remove(IMotorcycle model)
        {
            return this.motorcycles.Remove(model);
        }
    }
}