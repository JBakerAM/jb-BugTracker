using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace jb_BugTracker.Models
{
    public class Tickets
    {
        public Tickets()
        {
            this.TicketComments = new HashSet<TicketComments>();
            this.TicketAttachs = new HashSet<TicketAttachments>();
            this.TicketHists = new HashSet<TicketHistories>();
            this.TicketNotifs = new HashSet<TicketNotifications>();
        }
        public int Id { get; set; }
        public DateTimeOffset Created { get; set; }
        public DateTimeOffset? Updated { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int ProjectId { get; set; }
        public int TicketTypeId { get; set; }
        public int TicketPriorityId { get; set; }
        public int TicketStatusId { get; set; }
        public string OwnerUserId { get; set; }
        public virtual ApplicationUser OwnerUser { get; set; }
        public string AssignedToUserId { get; set; }
        public virtual ApplicationUser AssignedToUser { get; set; }
        public virtual ICollection<TicketComments> TicketComments { get; set; }
        public virtual ICollection<TicketAttachments> TicketAttachs { get; set; }
        public virtual ICollection<TicketHistories> TicketHists { get; set; }
        public virtual ICollection<TicketNotifications> TicketNotifs { get; set; }
        public virtual TicketStatuses TicketStatus { get; set; }
        public virtual TicketPriorities TicketPriority { get; set; }
        public virtual TicketTypes TicketType { get; set; }
        public virtual Projects Project { get; set; }




    }
}