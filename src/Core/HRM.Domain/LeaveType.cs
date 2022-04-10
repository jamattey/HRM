using System;
using System.Collections.Generic;
using System.Text;

namespace HRM.Domain
{
    public class NewBaseType
    {
        public int Id { get; set; }

        public string Name { get; set; }
        public int DefaultDays { get; set; }

        public DateTime DateCreated { get; set; }
    }
}
    
