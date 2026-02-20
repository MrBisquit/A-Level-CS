using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Please enter the gate you wish to use: ");
		string gate = Console.ReadLine();
		Console.Write("Please enter the first input: ");
		bool a = Console.ReadLine() == "1";
		Console.Write("Please enter the second input: ");
		bool b = Console.ReadLine() == "1";
		
		switch(gate.ToUpper()) {
			case "OR":
				Result(a || b);
				break;
			case "AND":
				Result(a && b);
				break;
			case "XOR":
				Result((a || b) && !(a && b));
				break;
			case "NAND":
				Result(!(a && b));
				break;
			case "NOR":
				Result(!(a || b));
				break;
		}
	}
	
	public static void Result(bool result) {
		Console.WriteLine($"Result = {(result ? "1" : "0")}");	
	}
}