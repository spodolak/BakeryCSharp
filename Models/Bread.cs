namespace Bakery.Models
{
	public class Bread 
	{
		public int Price {get;} = 5;
		public static int AddBread(int number)
		{
			int breadTotal = 0;
			for(int i=1; i <= number; i++)
			{
				if(i%3 != 0)
				{
					breadTotal += 5;
				} 
				else 
				{
					breadTotal += 0;
				}
			}
			return breadTotal;
		}
	}
}