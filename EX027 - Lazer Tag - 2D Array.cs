using System;
					
public class Program
{
	public static void Main()
	{
		int[,] player = {
			{1, 15}, {2, 25}, {1, 45}, {2, 45}, {1, 12}, {2, 55}, {1, 19}, {2, 45}, {1, 45}, {1, 45},
			{1, 1},  {2, 45}, {1, 45}, {1, 14}, {1, 45}, {2, 45}, {1, 15}, {1, 45}, {2, 45}, {1, 9}
		};
		
		int[] score = { 0, 0 };
		
		for(int i = 0; i < player.GetLength(0); i++) {
			score[player[i, 0] - 1] += player[i, 1];
		}
		
		Console.WriteLine("The green team scored: {0}\nThe red team scored: {1}",
						  score[0], score[1]);
		
		if(score[0] > score[1])
			Console.WriteLine("Red Team WINS!");
		else
			Console.WriteLine("Green Team WINS!");
	}
}