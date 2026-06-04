using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalAssistant.Application.Features.Payments.DTOs
{
    public sealed class VerifyPaymentDto
    {
        public string Authority { get; set; } = null!;

        public string Status { get; set; } = null!;
    }
}
