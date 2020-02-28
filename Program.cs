using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery 
{
	public class Program
	{
		public static void Main()
		{
			int OrderTotal = 0;
			// List<Item> Items = new List<Item>();
			Console.WriteLine("Welcome to the bakery!");
			PlaceOrder(OrderTotal);
		}
		public static void PlaceOrder(int OrderTotal)
		{
			Console.WriteLine("Would you like to buy a loaf of bread or pastry? (Press 1 or 2)");
			Console.WriteLine("1) Bread $2.00   2) Pastry $3.50"); 
			int orderType = int.Parse(Console.ReadLine());
			Order(orderType, OrderTotal);
		}
		public static void Order(int number, int OrderTotal)
		{
			if (number == 1) 
			{
				Console.WriteLine("How many loaves would you like to order?");
				int numOfLoaves = int.Parse(Console.ReadLine());
				int BreadTotal = Bread.AddBread(numOfLoaves);
				Console.WriteLine("Order Total: $" + BreadTotal +".00");
				ReOrder(BreadTotal);
			} 
			else if (number == 2)
			{
				Console.WriteLine("How many pastries would you like to order?");
				int numOfPastries = int.Parse(Console.ReadLine());
				int PastryTotal = Pastry.AddPastry(numOfPastries);
				Console.WriteLine("Order Total: $" + PastryTotal +".00");
				ReOrder(PastryTotal);
			}
		}
		public static void ReOrder(int currentTotal)
		{
			Console.WriteLine("Would you like to reorder?");
			Console.WriteLine("Y or N?");
			string answer = Console.ReadLine();
			if (answer.Equals("Y"))
			{
				PlaceOrder(currentTotal);
			}
			else {
				Console.WriteLine("Thank you! Come again.");
			}

		}
	}
}