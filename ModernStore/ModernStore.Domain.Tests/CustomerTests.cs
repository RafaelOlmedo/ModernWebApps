using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ModernStore.Domain.Entities;

namespace ModernStore.Domain.Tests
{
	[TestClass]
	public class CustomerTests
	{
		private User user = new User("rafael", "rafael");

		[TestMethod]
		[TestCategory("Customer - New Customer")]
		public void GivenAnInvalidFirstNameShouldReturnANotification()
		{
			var customer = new Customer("", "olmedo", "rafa-olmedo@hotmail.com", user);

			Assert.IsFalse(customer.IsValid());
		}

		[TestMethod]
		[TestCategory("Customer - New Customer")]

		public void GivenAnInvalidLastNameShouldReturnANotification()
		{
			var customer = new Customer("rafael", "", "rafa-olmedo@hotmail.com", user);

			Assert.IsFalse(customer.IsValid());
		}

		[TestMethod]
		[TestCategory("Customer - New Customer")]

		public void GivenAnInvalidEmailNameShouldReturnANotification()
		{
			var customer = new Customer("rafael", "olmedo", "r", user);

			Assert.IsFalse(customer.IsValid());
		}
	}
}
