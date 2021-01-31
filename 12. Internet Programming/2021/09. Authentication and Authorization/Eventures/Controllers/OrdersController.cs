using System;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Eventures.Data;
using Eventures.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace Eventures.Controllers
{
    [Authorize]
    public class OrdersController : Controller
    {
        private readonly IOrdersService ordersService;

        public OrdersController(IOrdersService ordersService)
        {
            this.ordersService = ordersService;
        }

        [HttpPost]
        public async Task<IActionResult> Create(OrderCreateBindingModel model)
        {
            if (!this.ModelState.IsValid)
            {
                return this.RedirectToAction("All", "Events");
            }

            var serviceModel = Mapper.Map<OrderServiceModel>(model);
            serviceModel.OrderedOn = DateTime.Now;

            var result = await this.ordersService.Create(serviceModel, this.User.Identity.Name);
            if (!result)
            {
                return this.RedirectToAction("All", "Events");
            }

            return this.RedirectToAction("My", "Events");
        }

        [Authorize(Roles = GlobalConstants.AdminRoleName)]
        public async Task<IActionResult> Index()
        {
            var orders = (await this.ordersService.GetAll())
                .Select(Mapper.Map<OrderListingViewModel>);

            return this.View(orders);
        }
    }
}
