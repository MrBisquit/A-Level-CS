using System;
					
public class Program
{
	public static void Main()
	{
		string[,] jediCouncil = {
			{"Yoda",			"Green"},
			{"Even Piell",		"Green"},
			{"Saesee Tiin",		"Green"},
			{"Mace Windu",		"Purple"},
			{"Plo Koon",		"Blue"},
			{"Oppo Rancisis",	"Green"},
			{"Ki Adi Mundi",	"Blue"}
		};
		
		Console.Write("Enter a number between 0 and 6");
		int row = int.Parse(Console.ReadLine());
		
		if(row < 0 || row > 6) {
			Console.WriteLine("Element not recognised");
			return;
		}
		
		Console.Write("Enter a number between 0 and 1");
		int col = int.Parse(Console.ReadLine());
		
		if(col < 0 || col > 6) {
			Console.WriteLine("Element not recognised");
			return;
		}
		
		Console.WriteLine(jediCouncil[row, col]);
	}
}