using eTicketManagement.Domain.Entities;

namespace eTicketManagement.Application.Contracts.Persistence
{
    public interface ICategoryRepository: IRepository<Category>
    {
        Task<List<Category>>  GetCategoriesWithEvents(bool includeHistory);
    }
}
