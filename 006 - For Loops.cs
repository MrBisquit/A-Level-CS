using System;
					
public class Program
{
	public static void Main()
	{
		// Normal
		
		for(int i = 10; i >= 0; i--)
			Console.WriteLine(i.ToString());
  
		// Extension
		for(int i = 0; i >= -100; i--)
			if(i % 2 == 0) Console.WriteLine(i.ToString());
	}
}