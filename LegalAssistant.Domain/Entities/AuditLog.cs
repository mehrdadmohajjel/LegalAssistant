using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalAssistant.Domain.Entities
{
    public sealed class AuditLog
    {
        public long Id { get; set; }

        public string Action { get; set; } = null!;

        public string EntityName { get; set; } = null!;

        public string EntityId { get; set; } = null!;

        public string? OldValues { get; set; }

        public string? NewValues { get; set; }

        public DateTime CreatedAtUtc { get; set; }
    }
}
