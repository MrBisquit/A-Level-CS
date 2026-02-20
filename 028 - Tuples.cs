using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		Tuple<int, string, string> person =
			Tuple.Create<int, string, string>(1, "Stephan", "Hawking");
		
		Console.WriteLine(person.Item1);
		Console.WriteLine(person.Item2);
		Console.WriteLine(person.Item3);
		
		Console.WriteLine();
		
		person = Tuple.Create<int, string, string>(2, "Amelia", "Earhart");
		
		Console.WriteLine(person.Item1);
		Console.WriteLine(person.Item2);
		Console.WriteLine(person.Item3);
	}
}