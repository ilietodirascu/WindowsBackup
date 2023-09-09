using Domain;
using Microsoft.EntityFrameworkCore;
using Persistance.EntityConfigurations;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Persistance
{
    public class CodePalsDbContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(CommentsConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(HashtagsConfiguration).Assembly);
            modelBuilder.ApplyConfigurationsFromAssembly(typeof(MessagesConfiguration).Assembly);
        }

        public DbSet<Question> Questions { get; set; }
        public DbSet<Event> Events { get; set; }
        public DbSet<Follower> Followers { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<Hashtag> Hashtags { get; set; }
        public DbSet<Friend> Friends { get; set; }
        public DbSet<User> Users{ get; set; }
        public DbSet<Conversation> Conversations { get; set; }
        public DbSet<Message> Messages { get; set; }
        public DbSet<Upvote> Upvotes { get; set; }




        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            var modifiedEntries = ChangeTracker.Entries()
                    .Where(x => x.State == EntityState.Added || x.State == EntityState.Modified);

            foreach (var entry in modifiedEntries)
            {
                if (entry.Entity is BaseEntity userTrackerEntity)
                {
                    userTrackerEntity.CreatedOn = DateTimeOffset.Now;
                }
            }

            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
