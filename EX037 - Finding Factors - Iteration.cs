using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Type a whole number: ");
		
		int num = 0;
		try {
			num = int.Parse(Console.ReadLine());
		} catch(Exception e) {
			Console.WriteLine("Invalid number ({0})", e.Message);
			Environment.Exit(1);
		}
		
		for(int i = 1; i < num + 1; i++) {
			if(num % i == 0)
				Console.WriteLine(i.ToString() + (IsPrime(i) ? " PRIME" : ""));
		}
	}
	
	public static bool IsPrime(int num) {
		if(num < 2) return false;
		if(num % 2 == 0) return num == 2;
		
		for(int i = 3; i * i <= num; i += 2)
			if(num % i == 0) return false;
		
		return true;
	}
}