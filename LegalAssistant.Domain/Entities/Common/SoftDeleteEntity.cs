using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalAssistant.Domain.Entities.Common
{
    public abstract class SoftDeleteEntity
    {
        public bool IsDeleted { get; set; }

        public DateTime? DeletedAtUtc { get; set; }
    }
}
