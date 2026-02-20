using System;
					
public class Program
{
	public static void Main()
	{
		int i = 10;
		while(i != -1) {
			Console.WriteLine($"The rocket will launch in {i} second{(i == 1 ? "" : "s")}");
			i--;
		}
		Console.WriteLine("Rocket Launched!");
	}
}