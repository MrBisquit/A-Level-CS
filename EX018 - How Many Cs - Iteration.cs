using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Enter your string: ");
		string str = Console.ReadLine().ToUpper();
		char[] chars = str.ToCharArray();
		if(!chars.Contains('C')) {
			Console.WriteLine("No Cs were found");
			return;
		}
		
		int longest = 0;
		int run = 0;
		for(int i = 0; i < chars.Length; i++) {
			if(chars[i] == 'C')
				run++;
			else {
				if(run > longest)
					longest = run;
				run = 0;
			}
		}
		if(run > longest)
			longest = run;
		
		Console.WriteLine($"Longest run of Cs = {longest}");
	}
}