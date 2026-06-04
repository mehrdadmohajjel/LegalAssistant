using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalAssistant.Domain.Entities
{
    public sealed class Payment
    {
        public long Id { get; set; }

        public long UserId { get; set; }

        public long ConsultationId { get; set; }

        public decimal Amount { get; set; }

        public string Authority { get; set; } = null!;

        public string? RefId { get; set; }

        public PaymentStatus Status { get; set; }

        public DateTime CreatedAtUtc { get; set; }

        public DateTime? VerifiedAtUtc { get; set; }

        public User User { get; set; } = null!;

        public Consultation Consultation { get; set; } = null!;
    }
}
