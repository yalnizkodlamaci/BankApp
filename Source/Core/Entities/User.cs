using Bank.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Core.Entities
{
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Guid Id { get; set; }
        public decimal Balance { get; set; }
        public UserRole Role { get; set; } = UserRole.Customer;
        public RegistrationStatus Status { get; set; } = RegistrationStatus.PendingApproval;
    }
}
