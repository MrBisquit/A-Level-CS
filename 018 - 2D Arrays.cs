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
		
		for(int i = 0; i < jediCouncil.GetLength(0); i++) {
			Console.WriteLine($"{i}");
			Console.WriteLine($"{jediCouncil[i, 1]}");	
		}
		
		int[] lightsabers = new int[3];
		for(int i = 0; i < jediCouncil.GetLength(0); i++) {
			switch(jediCouncil[i, 1]) {
				case "Green":
					lightsabers[0]++;
					break;
				case "Purple":
					lightsabers[1]++;
					break;
				case "Blue":
					lightsabers[2]++;
					break;
			}
		}
		
		Console.WriteLine($"Green = {lightsabers[0]}");
		Console.WriteLine($"Purple = {lightsabers[1]}");
		Console.WriteLine($"Blue = {lightsabers[2]}");
	}
}