namespace Bakery.Models
{
	public class Pastry 
	{
		public int Price {get; set;} = 2;
		public int AddPastry(int number)
		{
			int pastryTotal = 0;
			for(int i=1; i <= number; i++)
			{
				if(i%3 == 0)
				{
					pastryTotal += 1;
				} 
				else 
				{
					pastryTotal += Price;
				}
			}
			return pastryTotal;
		}
	}
}