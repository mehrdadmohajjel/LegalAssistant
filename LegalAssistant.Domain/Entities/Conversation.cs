using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalAssistant.Domain.Entities
{
    public sealed class Conversation
    {
        public long Id { get; set; }

        public long UserId { get; set; }

        public string Title { get; set; } = null!;

        public DateTime CreatedAtUtc { get; set; }

        public DateTime LastMessageAtUtc { get; set; }

        public bool IsClosed { get; set; }

        public User User { get; set; } = null!;

        public ICollection<Message> Messages { get; set; }
            = new List<Message>();
    }
}
