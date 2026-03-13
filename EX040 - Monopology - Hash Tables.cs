using System;
using System.Collections;
					
public class Program
{
	public static void Main()
	{
		Hashtable table = new() {
			{"Old Kent Road",			"Brown"},
			{"Whitechapel Road",		"Brown"},
			{"The Angel Islington",		"Light Blue"},
			{"Euston Road",				"Light Blue"},
			{"Pentonville Road",		"Light Blue"},
			{"Pall Mall",				"Pink"},
			{"Whitehall",				"Pink"},
			{"Northumberland Avenue",	"Pink"},
			{"Bow Street",				"Orange"},
			{"Marlborough Street",		"Orange"},
			{"Vine Street",				"Orange"},
			{"The Strand",				"Red"},
			{"Fleet Street",			"Red"},
			{"Trafalgar Square",		"Red"},
			{"Leicester Square",		"Yellow"},
			{"Coventry Street",			"Yellow"},
			{"Piccadilly",				"Yellow"},
			{"Regent Street",			"Green"},
			{"Oxford Street",			"Green"},
			{"Bond Street",				"Green"},
			{"Park Lane",				"Dark Blue"},
			{"Mayfair",					"Dark Blue"},
			{"King's Cross",			"Station"},
			{"Marylebone",				"Station"},
			{"Fenchurch St",			"Station"},
			{"Liverpool Street",		"Station"}
		};
		
		string[] places = {
			"Old Kent Road", 			"Whitechapel Road",
			"The Angel Islington",		"Euston Road",
			"Pentonville Road",			"Pall Mall",
			"Whitehall",				"Northumberland Avenue",
			"Bow Street",				"Marlborough Street",
			"Vine Street",				"The Strand",
			"Fleet Street",				"Trafalgar Square",
			"Leicester Square",			"Coventry Street",
			"Piccadilly",				"Regent Street",
			"Oxford Street",			"Bond Street",
			"Park Lane",				"Mayfair",
			"King's Cross",				"Marylebone",
			"Fenchurch St",				"Liverpool Street"
		};
		
		Console.Write("How many locations would you like to try and guess? ");
		int locations = int.Parse(Console.ReadLine());
		
		if(locations <= 0 || locations > places.Length) {
			Console.WriteLine("Invalid input");
			Environment.Exit(1);
		}
		
		int points = 0;
		
		// This should work, I think it's just dotnetfiddle not working
		
		int[] questions = PickQuestions(places.Length, locations);
		for(int i = 0; i < questions.Length; i++) {
			string place = places[questions[i]];
			
			Console.WriteLine($"What colour/type is the location: {place}?");
			Console.Write("Answer: ");
			string res = Console.ReadLine();
			
			if(table[place].ToString() == res) {
				Console.WriteLine("CORRECT + 2 POINTS");
				points += 2;
			} else {
				Console.WriteLine("INCORRECT - 1 POINT");
				points--;
			}
		}
		
		Console.WriteLine($"You attempted {locations} questions, and scored {points} points");
	}
	
	public static int[] PickQuestions(int total, int questions) {
		int[] qs = new int[questions];
		Random r = new Random();
		
		for(int i = 0; i < questions; i++) {
			int rand = r.Next(0, total);
			while(qs.Contains(rand))
				rand = r.Next(0, total);
			qs[i] = rand;
		}
			   
		return qs;
	}
}