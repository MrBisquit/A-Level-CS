using System;
					
public class Program
{
	public static void Main()
	{
		int[] temperatures = {
			19, 31, 3,  24, 37, 37, 32,
			13, 18, 3,  31, 39, 36, 29,
			13, 35, 39, 30, 38, 15, 8,
			14, 22, 7,  31, 29, 11, 8,
			23, 10, 2,  39, 2,  24, 25,
			25, 12, 30, 5,  39, 36, 39,
			13, 20, 23, 39, 9,  6,  24,
			17, 40, 34, 13, 27, 2,  33,
			40, 3,  6,  12, 14, 18, 26,
			24, 20, 11, 40, 17, 30, 37,
			2,  5,  26, 33, 5,  1,  39,
			23, 33, 31, 1,  4,  0,  10
		};
		
		int[] bands = { 0, 0, 0, 0 };
		for(int i = 0; i < temperatures.Length; i++) {
			bands[SelectBand(temperatures[i])]++;
		}
		
		Console.WriteLine($"Band A: {bands[0]}");
		Console.WriteLine($"Band B: {bands[1]}");
		Console.WriteLine($"Band C: {bands[2]}");
		Console.WriteLine($"Band D: {bands[3]}");
		Console.WriteLine($"\nTotal:  {temperatures.Length}");
	}
	
	public static int SelectBand(int temp) {
		if(temp <= 10)               return 0; // Band A
		if(temp >= 11 && temp <= 20) return 1; // Band B
		if(temp >= 21 && temp <= 30) return 2; // Band C
		if(temp >= 31)               return 3; // Band D
		return -1;
	}
}