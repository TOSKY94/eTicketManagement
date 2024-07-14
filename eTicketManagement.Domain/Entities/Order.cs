using eTicketManagement.Domain.Common;

namespace eTicketManagement.Domain.Entities
{
    public class Order: AuditableEntity
    {
        public Guid OrderId { get; set; }
        public Guid UserId { get; set; }
        public int OrderTotal { get; set; }
        public DateTime OrderDate { get; set; }
        public bool OrderPaid { get; set; }
    }
}
