using System;
using ModernStore.Domain.Entities;

namespace ModernStore.Console
{
	class Program
	{
		static void Main(string[] args)
		{
			var customer = new Customer("Rafael", 
				"Olmedo", 
				new DateTime(1992, 09, 14), 
				"rafaelolmedo", 
				"rafaelolmedo", 
				"rafael.olmedo@hotmail.com");

			System.Console.WriteLine($"{customer.FirstName} {customer.LastName}");
			System.Console.ReadKey();
		}
	}
}
