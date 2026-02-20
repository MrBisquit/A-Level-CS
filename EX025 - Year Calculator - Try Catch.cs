using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Please enter a year (e.g. 2015");
		try {
			char[] year = Console.ReadLine().ToCharArray();
			int total = 0;
			
			for(int i = 0; i < year.Length; i++)
				total += int.Parse($"{year[i]}");
			
			Console.WriteLine($"{string.Join("", year)} = {total}");
		} catch {
			Console.WriteLine("Invalid Year");
		}
	}
}