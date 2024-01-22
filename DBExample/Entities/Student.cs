using System;
namespace DBExample.Entities
{
	public class Student:BaseEntity
	{
		public string Number { get; set; }
        public byte Marks { get; set; }
        public byte Absenteeism { get; set; }
        public Guid UserId { get; set; }
        public virtual User User { get; set; }
    }
}

