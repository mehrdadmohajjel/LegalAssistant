using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalAssistant.Application.Features.Payments.DTOs
{
    public sealed class CreatePaymentDto
    {
        public long ConsultationId { get; set; }
    }
}
