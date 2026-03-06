using System;
					
public class Program
{
	public static void Main()
	{
		int score = 0;
		int rounds = 5;
		
		for(int i = 0; i < rounds; i++) {
			Console.WriteLine("Round {0}", i + 1);
			Console.Write("Heads or tails: (H/T) ");

			string opt = Console.ReadLine().ToUpper()[0] == 'H' ? "Heads" : "Tails";
			string res = coinflip();
			
			Console.WriteLine("Landed on {0}", res);

			if(opt == res) {
				score++;
				Console.WriteLine("Good guess!");
			} else
				Console.WriteLine("Better luck next time!");
			
			//Console.WriteLine("\tScore: {0}", score);
			Console.WriteLine();
		}
		
		Console.WriteLine("Your score: {0}/{1}", score, rounds);
	}
	
	public static string coinflip() {
		Random r = new Random();
		
		return r.Next(0, 2) == 1 ? "Heads" : "Tails";
	}
}