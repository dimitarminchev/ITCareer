using System.Collections.Generic;
using System.Linq;
using ViceCity.Models.Guns.Contracts;
using ViceCity.Repositories.Contracts;

namespace ViceCity.Repositories
{
    public class GunRepository : IRepository<IGun>
    {
        private Queue<IGun> models;

        public IReadOnlyCollection<IGun> Models => models;


        public void Add(IGun model)
        {
            if (!this.models.Contains(model))
            {
                this.models.Enqueue(model);
            }
        }

        public IGun Find(string name)
        {
            return this.models.FirstOrDefault(x => x.Name == name);
        }

        public bool Remove(IGun model)
        {
            if (!this.models.Contains(model))
            {                
                this.models.Dequeue();
                return true;
            }
            else return false;
        }

        public GunRepository()
        {
            this.models = new Queue<IGun>();
        }
    }
}
