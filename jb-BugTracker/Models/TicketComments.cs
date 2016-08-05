using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jb_BugTracker.Models
{
    public class TicketComments
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public string Comment { get; set; }
        public DateTimeOffset Created { get; set; }
        public string UserID { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual Tickets Tick { get; set; }
    }
}