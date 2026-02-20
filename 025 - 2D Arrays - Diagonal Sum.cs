using System;
					
public class Program
{
	public static void Main()
	{
		int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
		
		int sum = 0;
		
		for(int y = 0; y < 3; y++)
			for(int x = 0; x < 3; x++)
				if(x == y) sum += matrix[x, y];
		
		Console.WriteLine($"Sum of diagonal elements: {sum}");
	}
}