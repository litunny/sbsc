using System;
namespace Core.Model
{
    public class Job : BaseEntity
    {
        public string Name { get; set; }

        public int JobTypeId { get; set; }

        public virtual JobType JobType { get; set; }
    }
}
