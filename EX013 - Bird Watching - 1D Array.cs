using System;
					
public class Program
{
	public static void Main()
	{
		string[] birdName = {
			"robin", "blackbird", "pigeon",
			"magpie", "bluetit", "thrush",
			"wren", "starling"
		};
		
		Console.Write("Enter bird name: ");
		string name = Console.ReadLine().ToLower();
		
		for(int i = 0; i < birdName.Length; i++) {
			if(name == birdName[i]) {
				Console.WriteLine($"Bird found at {i}");
				return;
			}
		}
		
		Console.WriteLine("Bird species not in array");
	}
}