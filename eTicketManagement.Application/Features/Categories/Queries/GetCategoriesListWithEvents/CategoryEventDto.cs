namespace eTicketManagement.Application.Features.Categories.Queries.GetCategoriesListWithEvents
{
    public class CategoryEventDto
    {
        public Guid EventId { get; set; }
        public string EventName { get; set; } = string.Empty;

        public int Price { get; set; }
        public string Artist { get; set; }

        public DateTime Date { get; set; }

        public Guid categoryId { get; set; }


    }
}