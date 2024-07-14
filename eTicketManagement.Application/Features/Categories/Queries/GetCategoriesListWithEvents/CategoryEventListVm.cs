namespace eTicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents
{
    public class CategoryEventListVm
    {
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
        public ICollection<CategoryEventDto>? Events { get; set; }
    }
}