using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModernStore.Domain.Entities;

namespace ModernStore.Domain.Tests
{
	[TestClass]
	public class OrderTests
	{
		[TestMethod]
		public void GivenAnOutOfStockProductItShouldReturnAnError()
		{
			var user = new User("rafaelolmedo", "rafaelolmedo");
			var customer = new Customer("Rafael", "Olmedo", "rafa-olmedo@hotmail.com", user);

			var mouse = new Product("Mouse", 299, "mouse.jge", 0);
			
			var order = new Order(customer, 8, 10);
			order.AddItem(new OrderItem(mouse, 2));

			Assert.AreEqual(1, order.Notifications.Count);
		
		}

		[TestMethod]
		public void GivenAnInStockProductItShouldUpdateQuantityOnHand()
		{
			var user = new User("rafaelolmedo", "rafaelolmedo");
			var customer = new Customer("Rafael", "Olmedo", "rafa-olmedo@hotmail.com", user);

			var mouse = new Product("Mouse", 299, "mouse.jge", 20);

			var order = new Order(customer, 8, 10);
			order.AddItem(new OrderItem(mouse, 2));

			Assert.IsTrue(mouse.QuantityOnHand == 18);

		}
	}
}
