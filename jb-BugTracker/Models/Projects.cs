using jb_BugTracker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace jb_BugTracker.Models
{
    public class Projects
    {
        public Projects()
        {
            this.Ticks = new HashSet<Tickets>();
            this.Users = new HashSet<ApplicationUser>();
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Tickets> Ticks { get; set; }
        public virtual ICollection<ApplicationUser> Users { get; set; }
    }


    
}