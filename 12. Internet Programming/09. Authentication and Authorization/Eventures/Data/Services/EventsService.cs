using AutoMapper;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Eventures.Data
{
    public class EventsService : DataService, IEventsService
    {
        public EventsService(ApplicationDbContext context) : base(context)
        {
        }

        public async Task CreateAsync(EventServiceModel model)
        {
            if (!this.IsEntityStateValid(model))
            {
                return;
            }

            var ev = Mapper.Map<Event>(model);

            await this.context.AddAsync(ev);

            await this.context.SaveChangesAsync();
        }

        public async Task<IEnumerable<EventServiceModel>> GetAll()
        {
            return await this.context.Events
                .Where(e => e.TotalTickets > 0)
                .ProjectTo<EventServiceModel>()
                .ToArrayAsync();
        }
    }
}
