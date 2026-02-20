using System;
					
public class Program
{
	public static void Main()
	{
		int i = 10;
		do
			Console.WriteLine($"The rocket will launch in {i--} second{((i + 1) == 1 ? "" : "s")}");
		while(i > -1);
		Console.WriteLine("Rocket Launched!");
	}
}