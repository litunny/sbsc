using System;
namespace Core.Model
{
    public class Company : BaseEntity
    {
        public string Name { get; set; }

        public string Address { get; set; }

        public int IndustryId { get; set; }

        public virtual Industry Industry { get; set; }
    }
}
