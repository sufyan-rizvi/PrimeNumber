using System;

class Prime
{
	public static void Main(string [] args)
	{
		int myNumber;
		bool isPrime = true;
				
		Console.WriteLine("Input your number: ");
		myNumber = Convert.ToInt32(Console.ReadLine());
		
		
		for(int i = 2; i <= myNumber/2; i++)
		{
			if(myNumber % i == 0)
			{
				isPrime = false;
				break;

			}		
		}
		
		if(isPrime)
		{Console.WriteLine(myNumber + " is Prime");}

		else
		{Console.WriteLine(myNumber + " is not Prime");}
		
	}
}