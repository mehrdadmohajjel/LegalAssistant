using LegalAssistant.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalAssistant.Domain.Entities
{
    public sealed class Consultation
    {
        public long Id { get; set; }

        public long UserId { get; set; }

        public long ConversationId { get; set; }

        public ConsultationStatus Status { get; set; }

        public decimal Price { get; set; }

        public string Question { get; set; } = null!;

        public string? PreviewAnswer { get; set; }

        public string? FullAnswer { get; set; }

        public DateTime CreatedAtUtc { get; set; }

        public DateTime? PaidAtUtc { get; set; }

        public User User { get; set; } = null!;

        public Conversation Conversation { get; set; } = null!;
    }
}
