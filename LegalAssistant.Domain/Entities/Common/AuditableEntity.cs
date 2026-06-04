using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalAssistant.Domain.Entities.Common
{
    public abstract class AuditableEntity
        : BaseEntity
    {
        public string? CreatedBy { get; set; }

        public string? UpdatedBy { get; set; }
    }
}
