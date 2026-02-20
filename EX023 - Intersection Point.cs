using System;
					
public class Program
{
	public static void Main()
	{
		float a, b;
		float d, c;
		
		Console.Write("A: ");
		a = float.Parse(Console.ReadLine());
		
		Console.Write("B: ");
		b = float.Parse(Console.ReadLine());
		
		Console.WriteLine($"Line 1: y = {a}x + {b}");
		
		Console.Write("C: ");
		c = float.Parse(Console.ReadLine());
		
		Console.Write("D: ");
		d = float.Parse(Console.ReadLine());
		
		Console.WriteLine($"Line 2: y = {c}x + {d}");
		
		if(a == c) {
			Console.WriteLine("Both lines are parallel - no intersection point");
			return;
		}
		
		float x = (d - b) / (a - c);
		float y = (a * x) + b;
		
		Console.WriteLine($"Intersection point: ({x}, {y})");
	}
}