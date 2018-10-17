using ModersStore.Shared.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModernStore.Domain.Entities
{
	public class Product : Entity
	{
		public Product(string title, decimal price, string image, int quantityOnHand)
		{
			Title = title;
			Price = price;
			Image = image;
			QuantityOnHand = quantityOnHand;
		}


		public string Title { get; private set; }

		public decimal Price { get; private set; }

		public string Image { get; private set; }

		public int QuantityOnHand { get; private set; }

		public void DecreaseQuantity(int quantity) => QuantityOnHand -= quantity;
		
	}
}
