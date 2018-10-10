using FluentValidator;
using ModersStore.Shared.Entities;
using System;

namespace ModernStore.Domain.Entities
{
	public class Customer : Entity
	{
		public Customer(string firstName, string lastName, string email, User user)
		{			
			FirstName = firstName;
			LastName = lastName;			
			Email = email;
			User = user;

			new ValidationContract<Customer>(this)
				.IsRequired(x => x.FirstName, "Nome é obrigatório")
				.HasMaxLenght(x => x.FirstName, 60)
				.HasMinLenght(x => x.FirstName, 3)
			    .IsRequired(x => x.LastName, "Sobrenome é obrigatório")
				.HasMaxLenght(x => x.LastName, 60)
				.HasMinLenght(x => x.LastName, 3)
				.IsEmail(x => x.Email, "Valor informado não é de e-mail");
		}

		public string FirstName { get; private set; }

		public string LastName { get; private set; }

		public DateTime BirthDate { get; private set; }

		public string Email { get; private set; }

		public User User { get; private set; }

		public override string ToString()
		{
			return $"{FirstName} {LastName}";
		}
	}
}
