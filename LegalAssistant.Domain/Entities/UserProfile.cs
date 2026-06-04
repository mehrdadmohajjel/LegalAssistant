using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LegalAssistant.Domain.Entities
{
    public sealed class UserProfile
    {
        public long Id { get; set; }

        public long UserId { get; set; }

        public string FirstName { get; set; } = null!;

        public string LastName { get; set; } = null!;

        public string Mobile { get; set; } = null!;

        public string? NationalCode { get; set; }

        public string Province { get; set; } = null!;

        public string City { get; set; } = null!;

        public DateTime UpdatedAtUtc { get; set; }

        public User User { get; set; } = null!;
    }
}
