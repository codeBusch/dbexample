using System;
namespace DBExample.Entities
{
	public class Personnel
	{
		public decimal Salary { get; set; }
		public string SSN { get; set; }
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
    }
}

