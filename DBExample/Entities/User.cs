using System;
namespace DBExample.Entities;
	public class User:BaseEntity
	{
		public string UserName { get; set; }
		public string Password { get; set; }
		public string IdentificationNumber { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }
		public bool IsActive { get; set; }


}

