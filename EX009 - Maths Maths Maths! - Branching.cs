using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("1. Addition".PadRight(18) + "5. MOD Modulus");
		Console.WriteLine("2. Subtraction".PadRight(18) + "6. DIV Quotient");
		Console.WriteLine("3. Multiplication".PadRight(18) + "7. Exponontiation");
		Console.WriteLine("4. Division".PadRight(18));
		
		Console.Write("Selection (1-7): ");
		int selection = int.Parse(Console.ReadLine());
		if(selection < 1 || selection > 7) {
			Console.WriteLine("Invalid selection");
			return;
		}
		
		Console.Write("First value:  ");
		int a = int.Parse(Console.ReadLine());
		Console.Write("Second value: ");
		int b = int.Parse(Console.ReadLine());
		
		switch(selection) {
			case 1:
				Console.WriteLine($"{a} + {b} = {a + b}");
				break;
			case 2:
				Console.WriteLine($"{a} - {b} = {a - b}");
				break;
			case 3:
				Console.WriteLine($"{a} * {b} = {a * b}");
				break;
			case 4:
				if(a == 0 || b == 0) {
					Console.WriteLine("Neither value can be 0 for division");
					return;
				}
				Console.WriteLine($"{a} / {b} = {a / b}");
				break;
			case 5:
				Console.WriteLine($"{a} % {b} = {a % b}");
				break;
			case 6:
				Console.WriteLine($"{a} DIV {b} = {Math.DivRem(a, b)}");
				break;
			case 7:
				Console.WriteLine($"{a} ^ {b} = {Math.Pow(a, b)}");
				break;
		}
	}
}