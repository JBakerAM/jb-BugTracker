using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jb_BugTracker.Models
{
    public class TicketStatuses
    {
        public TicketStatuses()
        {
            Ticks = new HashSet<Tickets>();
        }
        public int Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Tickets> Ticks { get; set; }
    }
}