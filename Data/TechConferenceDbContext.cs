using Microsoft.EntityFrameworkCore;
using TechConference.Api.Data.Entities;

namespace TechConference.Data
{
    public class TechConferenceDbContext:DbContext
    {
        public TechConferenceDbContext(DbContextOptions<TechConferenceDbContext> options) : base(options)
        {
            this.Database.EnsureCreated();
        }
        public DbSet<Session> Sessions { get; set; }

        public DbSet<User> Users { get; set; }
    }
}
