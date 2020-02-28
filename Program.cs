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
			Console.WriteLine("Welcome to the bakery!");
			OrderTotal = PlaceOrder(OrderTotal);
			ShowOrder(OrderTotal);
			Console.WriteLine("Thank you! Come again.");
		}
		public static int PlaceOrder(int OrderTotal)
		{
			Console.WriteLine("Would you like to buy a loaf of bread or pastry? (Press 1 or 2)");
			Console.WriteLine("1) Bread $5.00   2) Pastry $2.00"); 
			int orderType = int.Parse(Console.ReadLine());
			return GetOrder(orderType, OrderTotal);
		}
		public static int GetOrder(int number, int OrderTotal)
		{
			if (number == 1) 
			{
				Bread breadOrder = new Bread();
				Console.WriteLine("How many loaves would you like to order?");
				int numOfLoaves = int.Parse(Console.ReadLine());
				OrderTotal += breadOrder.AddBread(numOfLoaves);
				Console.WriteLine("Order Total: $" + OrderTotal +".00");
				return ReOrder(OrderTotal);
			} 
			else if (number == 2)
			{
				Pastry pastryOrder = new Pastry();
				Console.WriteLine("How many pastries would you like to order?");
				int numOfPastries = int.Parse(Console.ReadLine());
				OrderTotal += pastryOrder.AddPastry(numOfPastries);
				Console.WriteLine("Order Total: $" + OrderTotal +".00");
				return ReOrder(OrderTotal);
			}
			else {
				return OrderTotal;
			}
		}
		public static int ReOrder(int OrderTotal)
		{
			Console.WriteLine("Would you like to reorder?");
			Console.WriteLine("Y or N?");
			string answer = Console.ReadLine();
			if (answer.Equals("Y"))
			{
				return PlaceOrder(OrderTotal);
			}
			else {
				return OrderTotal;
			}
		}
		public static void ShowOrder(int OrderTotal)
		{
			Console.WriteLine("Your Total: $" + OrderTotal + ".00");
		}
	}
}