using AutoMapper;
using eTicketManagement.Application.Contracts.Persistence;

namespace eTicketManagement.Application.Features.Events.Commands.DeleteEvent
{
    public class DeleteEventCommandHandler
    {
        private readonly IEventRepository _eventRepository;
        private readonly IMapper _mapper;

        public DeleteEventCommandHandler(IMapper mapper, IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }


        public async Task Handle(DeleteEventCommand request, CancellationToken cancellationToken)
        {
            var eventToDelete = await _eventRepository.GetById(request.EventId);
            await _eventRepository.Delete(eventToDelete);
        }
    }
}
