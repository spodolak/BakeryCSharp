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
			RainbowPrint("WELCOME TO THE BAKERY!");
			Console.WriteLine("-----------------------------------");
			OrderTotal = PlaceOrder(OrderTotal, orders);
			ShowOrder(OrderTotal, orders);
			RainbowPrint("Thank you!");
			RainbowPrint("Come Again");
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
		//Sorts user order by menu item...bread or pastry
		public static int GetOrder(int number, int OrderTotal, Orders orders) 
		{
			if (number == 1) 
			{
				return GetBread(number, OrderTotal, orders);
			} 
			else if (number == 2)
			{
				return GetPastry(number, OrderTotal, orders);
			}
			else {
				return OrderTotal;
			}
		}
		//Adds bread orders
		public static int GetBread(int number, int OrderTotal, Orders orders)
		{
			Bread breadOrder = new Bread();
			Console.WriteLine("How many loaves would you like to order?");
			int numOfLoaves = int.Parse(Console.ReadLine());
			int breadTotal = breadOrder.AddBread(numOfLoaves);
			OrderTotal += breadTotal;
			Console.WriteLine(numOfLoaves + " Loaves of Bread: $" + breadTotal + ".00");
			orders.SetOrder(numOfLoaves + " Loaves of Bread: $" + breadTotal + ".00");
			return ReOrder(OrderTotal, orders);
		}
		//Adds pastry orders
		public static int GetPastry(int number, int OrderTotal, Orders orders)
		{
			Pastry pastryOrder = new Pastry();
			Console.WriteLine("How many pastries would you like to order?");
			int numOfPastries = int.Parse(Console.ReadLine());
			int pastryTotal = pastryOrder.AddPastry(numOfPastries);
			OrderTotal += pastryTotal;
			Console.WriteLine(numOfPastries + " Pastries: $" + pastryTotal +".00");
			orders.SetOrder(numOfPastries + " Pastries: $" + pastryTotal +".00");
			return ReOrder(OrderTotal, orders);
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
		//Just for fun method that returns rainbow text
		public static void RainbowPrint(string text)
		{
			char[] rainbowArray = text.ToCharArray();
			ConsoleColor[] colors = (ConsoleColor[]) ConsoleColor.GetValues(typeof(ConsoleColor));
			int i = 1;
			foreach(char letter in rainbowArray)
			{
				if (i<15) {
					Console.ForegroundColor = colors[i];
					Console.Write(letter);
					i++;
				}
				else {
					i = 1;
					Console.ForegroundColor = colors[i];
					Console.Write(letter);
				}
			}
			Console.ForegroundColor = ConsoleColor.White;
			Console.WriteLine("");
		}
	}
}