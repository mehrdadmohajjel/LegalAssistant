using LegalAssistant.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalAssistant.Persistence.Context
{
    public sealed class AppDbContext : DbContext
    {
        public DbSet<User> Users => Set<User>();

        public DbSet<UserProfile> UserProfiles => Set<UserProfile>();

        public DbSet<Conversation> Conversations => Set<Conversation>();

        public DbSet<Message> Messages => Set<Message>();

        public DbSet<Consultation> Consultations => Set<Consultation>();

        public DbSet<Payment> Payments => Set<Payment>();

        public DbSet<TokenUsage> TokenUsages => Set<TokenUsage>();

        public DbSet<Subscription> Subscriptions => Set<Subscription>();

        public DbSet<AuditLog> AuditLogs => Set<AuditLog>();

        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(
                typeof(AppDbContext).Assembly);
        }
    }
}
