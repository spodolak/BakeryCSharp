using System;
using System.Collections.Generic;
using Bakery.Models;

namespace Bakery 
{
	public class Program
	{
		public static void Main()
		{
			Orders orders= new Orders() {};
			int OrderTotal = 0;
			Console.WriteLine("Welcome to The Bakery!");
			OrderTotal = PlaceOrder(OrderTotal, orders);
			ShowOrder(OrderTotal, orders);
			Console.WriteLine("Thank you!");
			Console.WriteLine("Come Again");
			RainbowPrint("testing");
		}
		 //Prompts user to place an order
		public static int PlaceOrder(int OrderTotal, Orders orders)
		{
			Console.WriteLine("Would you like to buy a loaf of bread or pastry? (Press 1 or 2)");
			Console.WriteLine("              MENU");
			Console.WriteLine("-----------------------------------");
			Console.WriteLine("1) Bread $5.00   2) Pastry $2.00"); 
			int orderType = int.Parse(Console.ReadLine());
			return GetOrder(orderType, OrderTotal, orders);
		}
		//Sorts user order by menu item. Asks user how many items they want to order. Stores price of order
		public static int GetOrder(int number, int OrderTotal, Orders orders) 
		{
			if (number == 1) 
			{
				Bread breadOrder = new Bread();
				Console.WriteLine("What kind of bread would you like to order?");
				Console.WriteLine("1) Rye, 2) Sourdough");
				Console.WriteLine("How many loaves would you like to order?");
				int numOfLoaves = int.Parse(Console.ReadLine());
				int breadTotal = breadOrder.AddBread(numOfLoaves);
				OrderTotal += breadTotal;
				Console.WriteLine(numOfLoaves + " Loaves of Bread: $" + breadTotal + ".00");
				orders.SetOrder(numOfLoaves + " Loaves of Bread: $" + breadTotal + ".00");
				return ReOrder(OrderTotal, orders);
			} 
			else if (number == 2)
			{
				Pastry pastryOrder = new Pastry();
				Console.WriteLine("What kind of pastry would you like to order?");
				Console.WriteLine("1) Chocolate Choux, 2) Cannoli");
				int pastryChoice = int.Parse(Console.ReadLine());
				Console.WriteLine("How many pastries would you like to order?");
				int numOfPastries = int.Parse(Console.ReadLine());
				int pastryTotal = pastryOrder.AddPastry(numOfPastries);
				OrderTotal += pastryTotal;
				Console.WriteLine(numOfPastries + " Pastries: $" + pastryTotal +".00");
				orders.SetOrder(numOfPastries + " Pastries: $" + pastryTotal +".00");
				return ReOrder(OrderTotal, orders);
			}
			else {
				return OrderTotal;
			}
		}
		//Asks user if they want to place another order
		public static int ReOrder(int OrderTotal, Orders orders)
		{
			Console.WriteLine("Would you like to place an additional order?");
			Console.WriteLine("Y or N?");
			string answer = Console.ReadLine();
			if (answer.Equals("Y"))
			{
				return PlaceOrder(OrderTotal, orders);
			}
			else {
				return OrderTotal;
			}
		}
		//Displays total after all orders have been made
		public static void ShowOrder(int OrderTotal, Orders orders)
		{
			orders.GetOrders();
			Console.WriteLine("-----------------------------------");
			Console.WriteLine("-----------------------------------");
			Console.WriteLine("YOUR TOTAL: $" + OrderTotal + ".00");
			Console.WriteLine("-----------------------------------");

		}
		public static void RainbowPrint(string text)
		{
			char[] rainbowArray = text.ToCharArray();
			List<string> Colors = new List<string>() { "Red", "Yellow", "Green", "Blue", "Magenta" };
			foreach(char letter in rainbowArray)
			{
				Console.ForegroundColor = ConsoleColor.Red;
				Console.Write(letter);
				Console.ForegroundColor = ConsoleColor.Yellow;
				Console.Write(letter);
			}
		}
	}
}