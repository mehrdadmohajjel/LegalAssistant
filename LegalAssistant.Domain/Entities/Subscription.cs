using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalAssistant.Domain.Entities
{
    public sealed class Subscription
    {
        public long Id { get; set; }

        public long UserId { get; set; }

        public string PlanName { get; set; } = null!;

        public decimal Price { get; set; }

        public int ConsultationLimit { get; set; }

        public int UsedConsultations { get; set; }

        public DateTime StartDateUtc { get; set; }

        public DateTime ExpireDateUtc { get; set; }

        public bool IsActive { get; set; }

        public User User { get; set; } = null!;
    }
}
