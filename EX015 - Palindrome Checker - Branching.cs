using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Please enter your test string: ");
		string str = Console.ReadLine();
		
		string lower = str.ToLower();
		char[] chars = lower.ToCharArray();
		chars.Reverse();
		string reverse = new string(chars);
		
		if(lower == reverse)
			Console.WriteLine($"{str} is a palindrome");
		else
			Console.WriteLine($"{str} is not a palindrome");
	}
}