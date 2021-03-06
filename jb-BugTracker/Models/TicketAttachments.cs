﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jb_BugTracker.Models
{
    public class TicketAttachments
    {
        public int Id { get; set; }
        public int TicketId { get; set; }
        public string FilePath { get; set; }
        public DateTimeOffset Created { get; set; }
        public string Description { get; set; }
        public string FileUrl { get; set; }
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }
        public virtual Tickets Tick { get; set; }
    }
}