using AutoMapper;
using eTicketManagement.Application.Contracts.Persistence;
using eTicketManagement.Domain.Entities;
using MediatR;

namespace eTicketManagement.Application.Features.Events.Commands.CreateEvent
{
    internal class CreateEventCommandHandler: IRequestHandler<CreateEventCommand, Guid>
    {
        private readonly IEventRepository _eventRepository;
        private readonly IMapper _mapper;

        public CreateEventCommandHandler(IMapper mapper, IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
        }

        public async Task<Guid> Handle(CreateEventCommand request, CancellationToken cancellationToken)
        {
            var @event = _mapper.Map<Event>(request);

            var validator = new CreateEventCommandValidator(_eventRepository);

            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0) 
            {
                throw new Exceptions.ValidationException(validationResult);
            }

            @event = await _eventRepository.Add(@event);

            return @event.EventId;
        }
    }
}
