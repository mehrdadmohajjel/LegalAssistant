using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalAssistant.Infrastructure.Options
{
    public sealed class BaleOptions
    {
        public const string SectionName = "Bale";

        public string Token { get; set; } = null!;

        public string BaseUrl { get; set; } = null!;
    }
}
