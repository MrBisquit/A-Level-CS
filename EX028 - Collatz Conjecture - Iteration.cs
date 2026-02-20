using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Starting number: ");
		int n = int.Parse(Console.ReadLine());
		if(0 > n)
			return;
		
		Console.Write($"{n}");
		while(n != 1) {
			if(n % 2 == 0) n /= 2;
			else		   { n *= 3; n += 1; }
			
			Console.Write($" | {n}");
		}
	}
}