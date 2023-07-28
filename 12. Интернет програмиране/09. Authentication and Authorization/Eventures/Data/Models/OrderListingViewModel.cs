using AutoMapper;
using Eventures.Data;
using System;

namespace Eventures.Models
{
    public class OrderListingViewModel : IHaveCustomMapping
    {
        public EventListingViewModel Event { get; set; }

        public string UserName { get; set; }

        public DateTime OrderedOn { get; set; }

        public int TicketsCount { get; set; }

        public void ConfigureMapping(IMapperConfigurationExpression mapper)
        {
            mapper.CreateMap<OrderServiceModel, OrderListingViewModel>()
                .ForMember(dest => dest.UserName, opt =>
                    opt.MapFrom(src => src.User.UserName));
        }
    }
}
