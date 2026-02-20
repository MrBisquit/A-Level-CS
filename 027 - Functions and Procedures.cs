using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Select a program to run (1-6): ");
		int pgrm = int.Parse(Console.ReadLine());
		
		switch(pgrm) {
			case 1:
				Program1();
				break;
			case 2:
				Program2();
				break;
			case 3:
				Program3();
				break;
			case 4:
				Program4();
				break;
			case 5:
				Program5();
				break;
			case 6:
				Program6();
				break;
			default:
				Console.WriteLine("Error: Invalid Program");
				Environment.Exit(1); // Exit code 1: Error
				break;
		}
	}
	
	public static void Program1() {
		Console.Write("Enter 3 whole numbers (space separated): ");
		string[] strs = Console.ReadLine().Split(' ');
		if(strs.Length != 3) {
			Console.WriteLine("Error: Invalid Input");
			Environment.Exit(1); // Exit code 1: Error
		}
		
		int a, b, c = 0;
		a = int.Parse(strs[0]);
		b = int.Parse(strs[1]);
		c = int.Parse(strs[2]);
		
		Console.WriteLine($"Average: {(a + b + c) / 3}");
	}
	
	public static void Program2() {
		Console.Write("Enter 2 whole numbers (space separated): ");
		string[] strs = Console.ReadLine().Split(' ');
		if(strs.Length != 2) {
			Console.WriteLine("Error: Invalid Input");
			Environment.Exit(1); // Exit code 1: Error
		}
		
		int a, b = 0;
		a = int.Parse(strs[0]);
		b = int.Parse(strs[1]);
		
		Console.WriteLine($"{(a > b ? a : b)} is greater than {(a < b ? a : b)}");
	}
	
	public static void Program3() {
		int a = 0;
		
		for(int i = 0; i < 100; i++)
			a += i + 1;
		
		Console.WriteLine($"Sum: {a}");
	}
	
	public static void Program4() {
		Console.Write("Enter a whole number: ");
		int num = int.Parse(Console.ReadLine());
		
		Console.WriteLine($"   {num}x");
		for(int i = 1; i < 13; i++) {
			Console.Write(i.ToString().PadLeft(2) + " ");
			Console.Write((i * num).ToString());
			Console.WriteLine();
		}
	}
	
	public static void Program5() {
		Random r = new Random();
		int num = r.Next(0, 100);
		
		while(true) {
			Console.Write($"Your guess: ");
			int guess = int.Parse(Console.ReadLine());
			
			if(num == guess) {
				Console.WriteLine("Correct!");
				break;
			} else {
				Console.WriteLine($"Incorrect (Hint: {(guess < num ? "Higher" : "Lower")})");
			}
		}
	}
	
	public static void Program6() {
		int[] array = { 7, 12, 4, 21, 8, 9 };
		int max = 0;
		
		for(int i = 0; i < array.Length; i++)
			if(array[i] > max)
				max = array[i];
		
		Console.WriteLine($"Max: {max}");
	}
}