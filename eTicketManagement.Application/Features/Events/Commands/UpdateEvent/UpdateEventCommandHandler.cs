using AutoMapper;
using eTicketManagement.Application.Contracts.Persistence;
using eTicketManagement.Domain.Entities;
using MediatR;

namespace eTicketManagement.Application.Features.Events.Commands.UpdateEvent
{
    public class UpdateEventCommandHandler: IRequestHandler<UpdateEventCommand>
    {
        private readonly IEventRepository _eventRepository;
        private readonly IMapper _mapper;

        public UpdateEventCommandHandler(IMapper mapper, IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }


        public async Task Handle(UpdateEventCommand request, CancellationToken cancellationToken)
        {
            var eventToUpdate = await _eventRepository.GetById(request.EventId);

            _mapper.Map(request, eventToUpdate, typeof(UpdateEventCommand), typeof(Event));

            await _eventRepository.Update(eventToUpdate);
        }
    }
}
