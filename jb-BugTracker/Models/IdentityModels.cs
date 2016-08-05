using System.Data.Entity;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Collections.Generic;

namespace jb_BugTracker.Models
{
    // You can add profile data for the user by adding more properties to your ApplicationUser class, please visit http://go.microsoft.com/fwlink/?LinkID=317594 to learn more.
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string DisplayName { get; set; }
        public ApplicationUser()
        {
            this.TicketComments = new HashSet<TicketComments>();
            this.TicketAttachs = new HashSet<TicketAttachments>();
            this.TicketHists = new HashSet<TicketHistories>();
            this.TicketNotifs = new HashSet<TicketNotifications>();
            this.Ticks = new HashSet<Tickets>();
            this.Projects = new HashSet<Projects>();
        }
        public virtual ICollection<TicketComments> TicketComments { get; set; }
        public virtual ICollection<TicketAttachments> TicketAttachs { get; set; }
        public virtual ICollection<TicketHistories> TicketHists { get; set; }
        public virtual ICollection<TicketNotifications> TicketNotifs { get; set; }
        public virtual ICollection<Tickets> Ticks { get; set; }
        public virtual ICollection<Projects> Projects { get; set; }

        public async Task<ClaimsIdentity> GenerateUserIdentityAsync(UserManager<ApplicationUser> manager)
        {
            // Note the authenticationType must match the one defined in CookieAuthenticationOptions.AuthenticationType
            var userIdentity = await manager.CreateIdentityAsync(this, DefaultAuthenticationTypes.ApplicationCookie);
            // Add custom user claims here
            return userIdentity;
        }
    }

    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext()
            : base("DefaultConnection", throwIfV1Schema: false)
        {
        }

        public static ApplicationDbContext Create()
        {
            return new ApplicationDbContext();
        }
        public DbSet<Tickets> Tick { get; set; }
        public DbSet<TicketComments> TicketComments { get; set; }
        public DbSet<TicketAttachments> TicketAttachs { get; set; }
        public DbSet<TicketHistories> TicketHists { get; set; }
        public DbSet<TicketNotifications> TicketNotifs { get; set; }
        public DbSet<TicketStatuses> TicketStatus { get; set; }
        public DbSet<TicketPriorities> TicketPriority { get; set; }
        public DbSet<TicketTypes> TicketType { get; set; }
        public DbSet<Projects> Project { get; set; }




    }
}