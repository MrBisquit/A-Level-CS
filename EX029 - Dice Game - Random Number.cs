using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("Three of a kind: 50 Points");
		Console.WriteLine("One pair: 10 Points");
		Console.WriteLine("Three even numbers: 15 Points");
		Console.WriteLine("Three odd numbers: 15 Points");
		Console.WriteLine("********************");
		Console.WriteLine("My name is Hervé Villechaize");
		
		Console.WriteLine();

		int[,] rolls = new int[10, 3];
		int points = 0;
		
		Random r = new();
		
		// Fancy table because why not
		Console.WriteLine("| Roll No | 1 | 2 | 3 | =OEP | + points |");
		Console.WriteLine("+---------+---+---+---+------+----------+");
		for(int i = 0; i < rolls.GetLength(0); i++) {
			Console.Write($"| Roll {(i + 1).ToString().PadRight(2)}");
			
			for(int j = 0; j < rolls.GetLength(1); j++)
				rolls[i, j] = r.Next(1, 6);
			
			int val = rolls[i, 0];
			bool equal = true;
			bool odd = true;
			bool even = true;
			int pair_val = rolls[i, 0];
			int num_same = 0;
			for(int j = 0; j < rolls.GetLength(1); j++) {
				if(rolls[i, j] != val)
					equal = false;
				
				if(rolls[i, j] % 2 == 0)
					odd = false;
				else
					even = false;
				
				if(rolls[i, j] == pair_val)
					num_same++;	
				else {
					num_same = 0;
					pair_val = rolls[i, j];
				}
				
				Console.Write($" | {rolls[i, j]}");
			}
			
			int before = points;
			
			if(equal)
				points += 50;
			if(odd || even)
				points += 15;
			if(num_same == 2)
				points += 10;
			
			Console.Write($" | {(equal ? "=" : " ")}{(odd ? "O": " ")}" +
						  $"{(even ? "E": " ")}{(num_same == 2 ? "P": " ")}");
			
			Console.WriteLine($" | + {(points - before).ToString().PadRight(6)} |");
		}
		Console.WriteLine("+---------+---+---+---+------+----------+");
		
		Console.WriteLine($"You scored {points} points for your {rolls.GetLength(0)} rolls");
	}
}