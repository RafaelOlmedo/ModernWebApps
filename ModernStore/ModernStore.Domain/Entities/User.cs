using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernStore.Domain.Entities
{
	public class User
	{

		public User(string username, string password)
		{
			Id = Guid.NewGuid();
			UserName = username;
			Password = password;
			Active = false;
		}

		public Guid Id { get; private set; }

		public string UserName { get; private set; }

		public string Password { get; private set; }

		public bool Active { get; private set; }

		public void Activate() =>
			Active = true;

		public void Desactivate() =>
			Active = false;

	}
}
