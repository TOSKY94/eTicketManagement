using eTicketManagement.Domain.Common;

namespace eTicketManagement.Domain.Entities
{
    public class Category: AuditableEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; } = string.Empty;

        public ICollection<Event>? Events { get; set; }
    }
}
