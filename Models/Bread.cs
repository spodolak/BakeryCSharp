namespace Bakery.Models
{
	public class Bread 
	{
		public int Price {get; set;} = 5;
		public int AddBread(int number)
		{
			int breadTotal = 0;
			for(int i=1; i <= number; i++)
			{
				if(i%3 != 0)
				{
					breadTotal += Price;
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