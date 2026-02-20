using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Percentage achieved: ");
		float percent = float.Parse(Console.ReadLine());
		
		if(percent >= 85)
			Console.WriteLine("Distinction");
		else if(percent >= 65 && percent <= 84)
			Console.WriteLine("Merit");
		else if(percent >= 40 && percent <= 64)
			Console.WriteLine("Pass");
		else
			Console.WriteLine("Fail");
	}
}