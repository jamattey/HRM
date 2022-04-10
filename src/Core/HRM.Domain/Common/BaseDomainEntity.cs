using System;
using System.Collections.Generic;
using System.Text;


namespace HRM.Domain.Common
{
    /// Base Entity is an abstract class which cannot be instantiated directly but can be inherited by everyone else
    public abstract class BaseDomainEntity
    {
        public int Id { get; set; }

        public DateTime DateCreated { get; set; }
        public string CreatedBy { get; set; }

        public DateTime LastModifiedDate { get; set; }
        public string LastModifiedBy { get; set; }


    }
}