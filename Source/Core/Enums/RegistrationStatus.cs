using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank.Core.Enums
{
    public enum RegistrationStatus
    {
        PendingApproval = 0,
        Active = 1,
        Rejected = 2,
        Suspended = 3,
        Banned = 4,
        Deleted = 5
    }
}
