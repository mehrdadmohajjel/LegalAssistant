using LegalAssistant.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalAssistant.Persistence.Configurations
{

    public sealed class UserConfiguration
        : IEntityTypeConfiguration<User>
    {
        public void Configure(
            EntityTypeBuilder<User> builder)
        {
            builder.ToTable("Users");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.BaleUserId)
                .HasMaxLength(100)
                .IsRequired();

            builder.HasIndex(x => x.BaleUserId)
                .IsUnique();
        }
    }
}
