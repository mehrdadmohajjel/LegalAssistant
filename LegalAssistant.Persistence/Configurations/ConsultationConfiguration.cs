using LegalAssistant.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LegalAssistant.Persistence.Configurations;

public sealed class ConsultationConfiguration
    : IEntityTypeConfiguration<Consultation>
{
    public void Configure(
        EntityTypeBuilder<Consultation> builder)
    {
        builder.ToTable("Consultations");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Price)
            .HasPrecision(18, 2);

        builder.Property(x => x.Question)
            .HasColumnType("nvarchar(max)");

        builder.Property(x => x.PreviewAnswer)
            .HasColumnType("nvarchar(max)");

        builder.Property(x => x.FullAnswer)
            .HasColumnType("nvarchar(max)");
    }
}