using System;
					
public class Program
{
	public static bool IsPrime(int n) {
		for(int i = 2; i < n; i++)
			if(n % i == 0)
				return false;
		return true;
	}
	
	public static void Main()
	{
		// 005
		for(int i = 0; i < 11; i++)
			Console.WriteLine(i.ToString());
		
		// Extension
		for(int i = 2; i < 1000; i++)
			if(IsPrime(i)) Console.WriteLine(i.ToString());
	}
}