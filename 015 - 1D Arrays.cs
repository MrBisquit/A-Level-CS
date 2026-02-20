using System;
					
public class Program
{
	public static void Main()
	{
		string[] jediCouncil = {
			"Yoda",
			"Eeven Piell",
			"Saesee Tiin",
			"Mace Windu",
			"Plo Koon",
			"Oppo Rancisis",
			"Ki Adi Mundi"
		};
		
		for(int i = 0; i < jediCouncil.Length; i++)
			Console.WriteLine(jediCouncil[^(i + 1)]);
	}
}