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
			} 
			else if (number == 2)
			{
				Console.WriteLine("How many pastries would you like to order?");
				int numOfPastries = int.Parse(Console.ReadLine());
				int PastryTotal = Pastry.AddPastry(numOfPastries);
				Console.WriteLine("Order Total: $" + PastryTotal +".00");
			}
		}
	}
}