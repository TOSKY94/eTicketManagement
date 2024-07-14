using eTicketManagement.Domain.Entities;

namespace eTicketManagement.Application.Contracts.Persistence
{
    public interface IEventRepository : IRepository<Event>
    {
        Task<bool> IsEventNameAndDateUnique(string eventName, DateTime date);
    }
}
