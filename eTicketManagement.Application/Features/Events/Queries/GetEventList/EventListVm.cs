using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eTicketManagement.Application.Features.Events.Queries.GetEventList
{
    public class EventListVm
    {
        public Guid EventId { get; set; }
        public string EventName { get; set; }
        public DateTime Date { get; set; }
        public string ImageUrl { get; set; }
    }
}
