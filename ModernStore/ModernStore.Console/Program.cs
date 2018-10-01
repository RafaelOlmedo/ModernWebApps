using System;
using ModernStore.Domain.Entities;

namespace ModernStore.Console
{
	class Program
	{
		static void Main(string[] args)
		{
			var user = new User("rafaelolmedo", "rafaelolmedo");

			var customer = new Customer("a", 
				"Olmedo", 
				new DateTime(1992, 09, 14), 
				"rafael.olmedohotmail.com",
				user);

			customer.User.Activate();

			if(!customer.IsValid())
			{
				foreach (var notification in customer.Notifications)
				{
					System.Console.WriteLine(notification.Message);
				}
			}

			//System.Console.WriteLine(customer.ToString());
			System.Console.ReadKey();
		}
	}
}
