namespace MXGP.Repositories
{
    using System.Collections.Generic;
    using MXGP.Models.Riders.Contracts;
    using MXGP.Repositories.Contracts;
    using System.Linq;

    public class RiderRepository : IRepository<IRider>
    {
        private readonly IList<IRider> riders;

        public RiderRepository()
        {
            this.riders = new List<IRider>();
        }

        public IRider GetByName(string name)
        {
            IRider rider = this.riders
                .FirstOrDefault(r => r.Name == name);

            return rider;
        }

        public IReadOnlyCollection<IRider> GetAll() => this.riders.ToList();

        public void Add(IRider model)
        {
            this.riders.Add(model);
        }

        public bool Remove(IRider model)
        {
            return this.riders.Remove(model);
        }
    }
}