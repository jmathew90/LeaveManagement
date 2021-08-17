using LeaveManagement.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace LeaveManagement.Data
{
    public class LeaveAllocation
    {
       
        public int Id { get; set; }

        public int NumberOfDays { get; set; }
        
        public DateTime DateCreated { get; set; }
      
        public EmployeeVM Employee { get; set; }
        public string EmployeeId { get; set; }
        [ForeignKey("LeaveTypeId")]
        public LeaveType LeaveType { get; set; }
        public int LeaveTypeId { get; set; }


        
    }
}
