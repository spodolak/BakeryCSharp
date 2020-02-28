namespace Bakery.Models
{
	public class Pastry 
	{
		public int Price {get;} = 3;
		public static int AddPastry(int number)
		{
			return number *= 3;
		}
	}
}