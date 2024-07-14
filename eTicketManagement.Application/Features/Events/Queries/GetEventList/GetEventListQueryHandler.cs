using AutoMapper;
using eTicketManagement.Application.Contracts.Persistence;
using eTicketManagement.Application.Features.Events.Queries.GetEventList;
using eTicketManagement.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTicketManagement.Application.Features.Events
{
    public class GetEventListQueryHandler: IRequestHandler<GetEventsListQuery, List<EventListVm>>
    {
        private readonly IRepository<Event> _eventRepository;
        private readonly IMapper _mapper;

        public GetEventListQueryHandler(IMapper mapper, IRepository<Event> eventRepository)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }
        public async Task<List<EventListVm>> Handle(GetEventsListQuery request, CancellationToken cancellationToken)
        {
            var allEvents = (await _eventRepository.ListAll()).OrderBy(x => x.Date);
            return _mapper.Map<List<EventListVm>>(allEvents);
        }
    }
}
