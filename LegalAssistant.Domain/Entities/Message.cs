using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalAssistant.Domain.Entities
{
    public sealed class Message
    {
        public long Id { get; set; }

        public long ConversationId { get; set; }

        public MessageRole Role { get; set; }

        public string Content { get; set; } = null!;

        public DateTime CreatedAtUtc { get; set; }

        public int PromptTokens { get; set; }

        public int CompletionTokens { get; set; }

        public Conversation Conversation { get; set; } = null!;
    }
}
