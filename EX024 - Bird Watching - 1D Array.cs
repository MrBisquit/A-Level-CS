using System;
					
public class Program
{
	public static void Main()
	{
		string[] birdName = {
			"robin",
			"blackbird",
			"pigeon",
			"magpie",
			"bluetit",
			"thrush",
			"wren",
			"starling"
		};
		
		int[] birdCount = new int[birdName.Length];
		
		while(true) {
			Console.WriteLine(	
		}
	}
}

// Found a different version, I think this is the complete version
using System;
					
public class Program
{
	public static void Main()
	{
		string[] birdName = {
			"robin",
			"blackbird",
			"pigeon",
			"magpie",
			"bluetit",
			"thrush",
			"wren",
			"starling"
		};
		
		int[] birdCount = new int[birdName.Length];
		
		while(true) {
			Console.Write("Please input name of bird (x to end): ");
			string name = Console.ReadLine().ToLower();
			if(name == "x")
				break;
			Console.Write("Number observed: ");
			int num = int.Parse(Console.ReadLine());
			for(int i = 0; i < birdName.Length; i++) {
				if(birdName[i] == name) {
					birdCount[i] += num;
					continue;
				}
			}
			Console.WriteLine("Invalid bird");
		}
		
		for(int i = 0; i < birdName.Length; i++)
			Console.WriteLine("{0}: {1}", birdName[i], birdCount[i]);
	}
}