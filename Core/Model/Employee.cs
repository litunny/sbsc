using System;
using System.Collections.Generic;

namespace Core.Model
{
    public class Employee : BaseEntity
    {
        public int AppUserId { get; set; }

        public virtual AppUser AppUser { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PhoneNumber { get; set; }

        public int JobId { get; set; }

        public virtual Job Job { get; set; }

        public IEnumerable<Employment> EmploymentHistory { get; set; }
    }
}
