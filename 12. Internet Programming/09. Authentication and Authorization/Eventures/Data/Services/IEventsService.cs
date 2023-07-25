using System.Collections.Generic;
using System.Threading.Tasks;

namespace Eventures.Data
{
    public interface IEventsService
    {
        Task CreateAsync(EventServiceModel model);

        Task<IEnumerable<EventServiceModel>> GetAll();
    }
}
