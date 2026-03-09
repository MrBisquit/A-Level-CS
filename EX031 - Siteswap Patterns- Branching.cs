using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Enter first number: ");
		int first = int.Parse(Console.ReadLine());
		
		Console.Write("Enter second number: ");
		int second = int.Parse(Console.ReadLine());
		
		Console.Write("Enter third number: ");
		int third = int.Parse(Console.ReadLine());
		
		if((first + second + third) % 3 > 0)
			return;
		if(first == second - 1 || second == third - 1 || third == first - 1)
			return;
		
		Console.WriteLine("{0}{1}{2} is a valid siteswap", first, second, third);
	}
}
