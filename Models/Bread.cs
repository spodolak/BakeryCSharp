namespace Bakery.Models
{
	public class Bread 
	{
		public int Price {get;} = 2;
		public static int AddBread(int number)
		{
			return number *= 2;
		}
	}
}