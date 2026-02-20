using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Enter an RGB value (space separated): ");
		string[] parts = Console.ReadLine().Split(' ');
		if(!CheckStr(parts)) {
			Console.WriteLine("Invalid string entered");
			Environment.Exit(1);
		}
		int r = int.Parse(parts[0]);
		int g = int.Parse(parts[1]);
		int b = int.Parse(parts[2]);
		if(!CheckRGB(r, g, b)) {
			Console.WriteLine("Invalid RGB value entered");
			Environment.Exit(1);
		}
		
		string oh = $"{ToHex(r)}{ToHex(g)}{ToHex(b)}";
		
		int cr = 255 - r;
		int cg = 255 - b;
		int cb = 255 - b;
		
		string ch = $"{ToHex(cr)}{ToHex(cg)}{ToHex(cb)}";
		
		string fr = $"{r.ToString().PadLeft(3, '0')}";
		string fg = $"{g.ToString().PadLeft(3, '0')}";
		string fb = $"{b.ToString().PadLeft(3, '0')}";
		
		string fcr = $"{cr.ToString().PadLeft(3, '0')}";
		string fcg = $"{cg.ToString().PadLeft(3, '0')}";
		string fcb = $"{cb.ToString().PadLeft(3, '0')}";
		
		Console.WriteLine($"Original Colour      - R:{fr} G:{fg} B:{fg}");
		Console.WriteLine("                       R G B");
		Console.WriteLine($"                 HEX - {oh}");
		
		Console.WriteLine($"Complementary Colour - R:{fcr} G:{fcg} B:{fcg}");
		Console.WriteLine("                       R G B");
		Console.WriteLine($"                 HEX - {ch}");
	}
	
	public static string ToHex(int input) {
		return input.ToString("X");
	}
	
	public static bool CheckStr(string[] input) {
		return input.Length < 3;
	}
	
	public static bool CheckRGB(int r, int g, int b) {
		return !(r > 255 || r < 0 ||
		   g > 255 || g < 0 ||
		   b > 255 || b < 0);
	}
}