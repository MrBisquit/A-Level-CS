using System;
					
public class Program
{
	public static void Main()
	{
		string[,] jediCouncil = {
			{"Yoda",			"Green", 	"Small green dude"},
			{"Even Piell",		"Green", 	"A Jedi with long ears"},
			{"Saesee Tiin",		"Green", 	"A Jedi with horns"},
			{"Mace Windu",		"Purple", 	"A human Jedi"},
			{"Plo Koon",		"Blue", 	"A wise Jedi"},
			{"Oppo Rancisis",	"Green", 	"A Thisspiansian Jedi"},
			{"Ki Adi Mundi",	"Blue", 	"A Cerean Jedi"}
		};
		
		for(int i = 0; i < jediCouncil.GetLength(0); i++) {
			Console.WriteLine(jediCouncil[i, 0].PadRight(14) +
							 jediCouncil[i, 1].PadRight(7) +
							 jediCouncil[i, 2]);
		}
	}
}