using System;
using ModernStore.Domain.Entities;

namespace ModernStore.ConsoleTest
{
	class Program
	{
		static void Main(string[] args)
		{
			var user = new User("rafaelolmedo", "rafaelolmedo");
			var customer = new Customer("Rafael", "Olmedo", "rafa-olmedo@hotmail.com", user);

			var mouse = new Product("Mouse", 299, "mouse.jge", 5);
			var mousePad = new Product("MousePad", 99, "mousePad.jge", 7);
			var teclado = new Product("Teclado", 599, "teclado.jge", 2);

			var order = new Order(customer, 8, 10);

			order.AddItem(new OrderItem(mouse, 2));
			order.AddItem(new OrderItem(mousePad, 3));
			order.AddItem(new OrderItem(teclado, 1));

			Console.WriteLine($"Número do Pedido {order.Number}");
			Console.WriteLine($"Data: {order.CreateDate :dd/MM/yyyy}");
			Console.WriteLine($"Desconto: {order.Discount}");
			Console.WriteLine($"Taxa de entrega: {order.DeliveryFee}");
			Console.WriteLine($"SubTotal: {order.SubTotal()}");
			Console.WriteLine($"Total: {order.Total()}");
			Console.WriteLine($"Cliente: {order.Customer.ToString()}");







			//System.Console.WriteLine(customer.ToString());
			System.Console.ReadKey();
		}
	}
}
