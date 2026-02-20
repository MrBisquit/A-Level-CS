using System;
using System.IO;

public class Program
{
	public static void Main()
	{
		string filePath = "dontLookBackInAnger.txt";

		string[] lyrics = {
			"Slip inside the eye of your mind",
			"Don't you know you might find",
			"A better place to play",
			"You said that you've never been",
			"But all the things that you've seen",
			"Will slowly fade away"
		};
		
		File.WriteAllLines(filePath, lyrics);
		
		string[] lyrics2 = File.ReadAllLines(filePath);
		
		for(int i = 0; i < lyrics2.Length; i++)
			Console.WriteLine(lyrics2[i]);
	}
}