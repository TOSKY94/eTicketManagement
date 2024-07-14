using AutoMapper;
using eTicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents;
using eTicketManagement.Application.Features.Categories.Queries.GetCategoryList;
using eTicketManagement.Application.Features.Events.Commands.CreateEvent;
using eTicketManagement.Application.Features.Events.Commands.UpdateEvent;
using eTicketManagement.Application.Features.Events.Queries.GetEventDetail;
using eTicketManagement.Application.Features.Events.Queries.GetEventList;
using eTicketManagement.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTicketManagement.Application.Profiles
{
    public class MappingProfile: Profile
    {
        public MappingProfile() 
        {
            CreateMap<Event, EventListVm>().ReverseMap();
            CreateMap<Event, EventDetailVm>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
            CreateMap<Category, CategoryListVm>();
            CreateMap<Category, CategoryEventListVm>();
            CreateMap<Event, CreateEventCommand>().ReverseMap();
            CreateMap<Event, UpdateEventCommand>().ReverseMap();
            CreateMap<Event, CategoryEventDto>().ReverseMap();
        }
    }
}
