using System;
					
public class Program
{
	public static void Main()
	{
		int num = 10;
		bool divisible = false;
		
		while(!divisible) {
			num++;
			divisible = true;
			
			for(int i = 2; i < 10; i++) {
				if(num % i != 0)
					divisible = false;
			}
		}
		
		Console.WriteLine(num);
	}
}