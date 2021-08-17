using System;
using Microsoft.AspNetCore.Identity;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Data
{
    public class Employee : IdentityUser
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }

        public string TaxId { get; set; }
        public DateTime DateOfBrith { get; set; }

        public DateTime DateJoined { get; set; }
        
       


    }
}
