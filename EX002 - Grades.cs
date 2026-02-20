using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("What grade did you get? ");
		char grade = Console.ReadLine().ToUpper()[0];
		if(grade == 'A' || grade == 'B')
			Console.WriteLine("Well Done");
		else if(grade == 'C')
			Console.WriteLine("Room for Improvement");
		else
			Console.WriteLine("Try Harder");
	}
}