using System;
using System.Collections.Generic;
using System.Text;

namespace HRM.Domain
{
    public class LeaveAllocation : BaseDomainEntity
    {
        public int Id { get; set; }
        public int NumberOfDays { get; set; }

        public DateTime DateCreated { get; set; }
        public leaveType LeaveType { get; set; }

        public int LeaveTypeId { get; set; }
        public int Period { get; set; }
    }
}