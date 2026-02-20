using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Enter number A: ");
		int a = int.Parse(Console.ReadLine());
		Console.Write("Enter number B: ");
		int b = int.Parse(Console.ReadLine());
		
		if(a < b)
			Console.WriteLine("A is less than B");
		else if(a > b)
			Console.WriteLine("A is more than B");
		else if(a == b)
			Console.WriteLine("A and B are the same!");
	}
}