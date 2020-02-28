using System;
using System.Collections.Generic;
namespace Bakery.Models
{
  public class Orders
	{
		private static List<string> _orders = new List<string> {};
		public void SetOrders(string order)
		{
			_orders.Add(order);
		}
		public void GetOrders()
		{
			foreach(string order in _orders)
			{
				Console.WriteLine(order);
			}
		} 
	}
}