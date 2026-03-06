using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Please enter the speed (in MPH): ");
		float speed = int.Parse(Console.ReadLine()) * 0.447f;
		
		Console.Write("Please enter the conditions: (dry/wet/icy) ");
		string conditions = Console.ReadLine().ToLower();
		
		float friction = 0.0f;		// Friction
		float tr = 1.5f; 			// Reaction time
		switch(conditions) {
			case "dry":
				friction = 0.7f;
				break;
			case "wet":
				friction = 0.5f;
				break;
			case "icy":
				friction = 0.3f;
				break;
		}
		
		// RD = v * tr;
		// BD = (v^2) / (2 * friction * 9.81)
		// D  = RD + BD
		// D  = (v * tr) + ((v^2) / (2 * friction * 9.81))
		float distance = (speed * tr) + (((float)Math.Pow(speed, 2.0f)) / (2.0f * friction * 9.81f));
		
		Console.WriteLine($"The estimated stopping distance would be {distance} meters");
	}
}