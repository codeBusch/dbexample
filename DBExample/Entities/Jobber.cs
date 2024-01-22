using System;
namespace DBExample.Entities
{
	public class Jobber : BaseEntity
	{
		public string Plate { get; set; }

        public string WorkArea { get; set; }

		public Guid UserId { get; set; }
		public virtual User User { get; set; }
	}
}

