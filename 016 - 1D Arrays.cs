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
		
		Console.Write("Enter a number between 0 and 6: ");
		int i = int.Parse(Console.ReadLine());
		if(i < 0 || i > 6) {
			Console.WriteLine("Element not recognised");
			return;
		}
		Console.WriteLine(jediCouncil[i]);
	}
}