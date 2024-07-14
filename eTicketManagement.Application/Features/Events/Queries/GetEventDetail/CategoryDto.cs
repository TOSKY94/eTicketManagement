namespace eTicketManagement.Application.Features.Events.Queries.GetEventDetail
{
    public class CategoryDto
    {
        public Guid CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;
    }
}