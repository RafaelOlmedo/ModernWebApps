using FluentValidator;
using System;

namespace ModersStore.Shared.Entities
{
	public abstract class Entity : Notifiable
	{
		protected Entity()
		{
			id = Guid.NewGuid();
		}

		public Guid id { get; private set; }
	}
}
