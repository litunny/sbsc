using System;
namespace Core.Model
{
    public class Employment : BaseEntity
    {
        public int EmployeeId { get; set; }

        public virtual Employee Employee { get; set; }

        public int JobId { get; set; }

        public virtual Job Job { get; set; }

        public int CompanyId { get; set; }

        public virtual Company Company { get; set; }

        public double Salary { get; set; }

        public EmploymentStatus EmploymentStatus { get; set; }

        public DateTime StartDate { get; set; }

        public DateTime EndDate { get; set; }

    }

    public enum EmploymentStatus
    {
        FRESH = 0,
        TRANSFER
    }
}
