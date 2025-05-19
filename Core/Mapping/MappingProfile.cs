using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Core.DTOs.Customers;
using Core.DTOs.Orders;
using Core.Models;
using Core.Models.Customers;
using Core.Models.Orders;
namespace Core.Mapping
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<OrderItem, OrderItemDto>()
               .ForMember(dest => dest.Amount, opt => opt.MapFrom(src => src.Quantity))
               .ForMember(dest => dest.Type, opt => opt.MapFrom(src => src.Item.Type))
               .ForMember(dest => dest.Size, opt => opt.MapFrom(src => src.Item.Size))
               .ForMember(dest => dest.MinPrice, opt => opt.MapFrom(src => src.Item.MinPrice))
               .ForMember(dest => dest.MaxPrice, opt => opt.MapFrom(src => src.Item.MaxPrice))
               .ReverseMap();
            CreateMap<Customer, UserDto>().ReverseMap();
            CreateMap<ContactCustomer, MessageDto>()
                .ForMember(dest => dest.User, opt => opt.MapFrom((src, dest, destMember, context) => context.Mapper.Map<UserDto>((Customer)src)))
                .ReverseMap();
        }
    }
}
