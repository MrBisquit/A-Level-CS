using System;
					
public class Program
{
	public static void Main()
	{
		int[,] matrix = { { 12, 23, 45, 67 }, { 78, 56, 89, 90 }, { 34, 65, 77, 29 }, { 19, 31, 73, 81 } };
		
		int max = 0;
		for(int y = 0; y < 4; y++)
			for(int x = 0; x < 4; x++)
				if(matrix[x, y] > max) max = matrix[x, y];
		
		Console.WriteLine($"Maximum value: {max}");
	}
}