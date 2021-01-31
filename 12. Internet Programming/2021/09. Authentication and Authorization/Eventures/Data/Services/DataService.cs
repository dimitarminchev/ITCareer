using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventures.Data
{
    public abstract class DataService : BaseService
    {
        protected readonly ApplicationDbContext context;

        protected DataService(ApplicationDbContext context)
        {
            this.context = context;
        }
    }
}
