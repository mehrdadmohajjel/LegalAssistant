using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalAssistant.Domain.Entities
{
    public sealed class User
    {
        public long Id { get; set; }

        public string BaleUserId { get; set; } = null!;

        public string? UserName { get; set; }

        public DateTime CreatedAtUtc { get; set; }

        public bool IsBlocked { get; set; }

        public ICollection<Conversation> Conversations { get; set; }
            = new List<Conversation>();

        public UserProfile Profile { get; set; } = null!;

        public ICollection<Payment> Payments { get; set; }
            = new List<Payment>();

        public ICollection<Consultation> Consultations { get; set; }
            = new List<Consultation>();

        public ICollection<TokenUsage> TokenUsages { get; set; }
            = new List<TokenUsage>();
    }
}
