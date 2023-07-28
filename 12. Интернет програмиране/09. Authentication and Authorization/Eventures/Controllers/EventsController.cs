using AutoMapper;
using Eventures.Data;
using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Eventures.Models;

namespace Eventures.Controllers
{
    public class EventsController : Controller
    {
        private readonly IEventsService eventsService;
        private readonly IOrdersService ordersService;
        private readonly ILogger logger;

        public EventsController(IEventsService eventsService, ILogger<EventsController> logger,
            IOrdersService ordersService)
        {
            this.eventsService = eventsService;
            this.logger = logger;
            this.ordersService = ordersService;
        }

        [Authorize]
        public async Task<IActionResult> All(int? page)
        {
            if (!page.HasValue || page.Value < 1)
            {
                page = 1;
            }

            var allEvents = await this.eventsService.GetAll();

            var allEventsArr = allEvents as EventServiceModel[] ?? allEvents.ToArray();

            var events = allEventsArr
                .OrderBy(e => e.StartDate)
                .Skip(10 * (page.Value - 1))
                .Take(10)
                .Select(Mapper.Map<EventListingViewModel>)
                .ToArray();

            return this.View(new AllEventsViewModel
            {
                Events = events,
                CurrentPage = page.Value,
                PageCount = (int)Math.Ceiling((double)allEventsArr.Length / 10)
            });
        }

        [Authorize]
        public async Task<IActionResult> My()
        {
            var orders = (await this.ordersService
                    .GetAllForUser(this.User.Identity.Name))
                .Select(Mapper.Map<OrderListingViewModel>);

            return this.View(orders);
        }

        [Authorize(Roles = GlobalConstants.AdminRoleName)]
        public IActionResult Create()
        {
            return this.View();
        }

        [HttpPost]
        [Authorize(Roles = GlobalConstants.AdminRoleName)]
        public async Task<IActionResult> Create(EventCreateBindingModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.View();
            }

            var serviceModel = Mapper.Map<EventServiceModel>(model);

            await this.eventsService.CreateAsync(serviceModel);

            this.logger.LogInformation("Event created: " + serviceModel.Name, serviceModel);

            return this.RedirectToAction("All");
        }

        
    }
}
