using System;
using System.Collections.Generic;

namespace SuperShop.Entity
{
	public class User
	{
		public string username { get; set; }
		public string password { get; set; }

		public string firstName { get; set; }

		public string lastName { get; set; }

		public UserRole userRole { get; set; }
	}

	public class UserRole
    {
		public string RoleName { get; set; }
		public int roleID { get; set; }
		public ICollection<User> users { get; set; }

		public override string ToString()
		{
			return this.RoleName;
		}
	}
}
