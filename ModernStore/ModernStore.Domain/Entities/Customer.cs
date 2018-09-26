using System;

namespace ModernStore.Domain.Entities
{
	public class Customer
	{
		public Customer(string firstName, string lastName, DateTime birthDate, string userName, string password, string email)
		{
			Id = Guid.NewGuid();
			FirstName = firstName;
			LastName = lastName;
			Active = false;
			BirthDate = birthDate;
			UserName = userName;
			Password = password;
			Email = email;
		}

		public Guid Id { get; set; }

		public string FirstName { get; set; }

		public string LastName { get; set; }

		public DateTime BirthDate { get; set; }

		public bool Active { get; set; }

		public string UserName { get; set; }

		public string Password { get; set; }

		public string Email { get; set; }
	}
}
