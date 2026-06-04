using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalAssistant.Domain.Entities
{
    public sealed class TokenUsage
    {
        public long Id { get; set; }

        public long UserId { get; set; }

        public string Model { get; set; } = null!;

        public int PromptTokens { get; set; }

        public int CompletionTokens { get; set; }

        public decimal EstimatedCost { get; set; }

        public DateTime CreatedAtUtc { get; set; }

        public User User { get; set; } = null!;
    }
}
