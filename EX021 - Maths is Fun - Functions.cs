using System;
					
public class Program
{
	public static void Main()
	{
		Console.WriteLine("What do you want to do?\n");
		
		Console.WriteLine("\tA: getHypotenuse()\n\tB: isIsosceles()\n\tC: isEquilateral()\n\tD: getAngle()\n\tE: getArea()\n\tF: getPerimeter()\n");

		string choice = Console.ReadLine().ToUpper();
		
		double a, b, c, tBase, tHeight;
		
		switch(choice) {
			case "A":
				{
					Console.Write("Enter length of side A: ");
					a = double.Parse(Console.ReadLine());
					
					Console.Write("Enter length of side B: ");
					b = double.Parse(Console.ReadLine());
					
					Console.WriteLine(getHypotenuse(a, b));
				}
				break;
			case "B":
				{
					Console.Write("Enter length of side A: ");
					a = double.Parse(Console.ReadLine());
					
					Console.Write("Enter length of side B: ");
					b = double.Parse(Console.ReadLine());
					
					Console.Write("Enter length of side C: ");
					c = double.Parse(Console.ReadLine());
					
					Console.WriteLine(getIsosceles(a, b, c));
				}
				break;
			case "C":
				{
					Console.Write("Enter length of side A: ");
					a = double.Parse(Console.ReadLine());
					
					Console.Write("Enter length of side B: ");
					b = double.Parse(Console.ReadLine());
					
					Console.Write("Enter length of side C: ");
					c = double.Parse(Console.ReadLine());
					
					Console.WriteLine(getEquilateral(a, b, c));
				}
				break;
			case "D":
				{
					Console.Write("Angle A: ");
					a = double.Parse(Console.ReadLine());
					
					Console.Write("Angle B: ");
					b = double.Parse(Console.ReadLine());
					
					Console.WriteLine(getAngle(a, b));
				}
				break;
			case "E":
				{
					Console.Write("Enter length of side A: ");
					a = double.Parse(Console.ReadLine());
					
					Console.Write("Enter length of side B: ");
					b = double.Parse(Console.ReadLine());
					
					Console.WriteLine(getArea(a, b));
				}
				break;
			case "F":
				{
					Console.Write("Enter length of side A: ");
					a = double.Parse(Console.ReadLine());
					
					Console.Write("Enter length of side B: ");
					b = double.Parse(Console.ReadLine());
					
					Console.Write("Enter length of side C: ");
					c = double.Parse(Console.ReadLine());
					
					Console.WriteLine(getPerimeter(a, b, c));
				}
				break;
		}
	}
	
	static double getPerimeter(double a, double b, double c) {
		return a + b + c;
	}
	
	static double getArea(double tBase, double tHeight) {
		return (tBase * tHeight) / 2;
	}
	
	static double getAngle(double angle1, double angle2) {
		return 180 - angle1 - angle2;
	}
	
	static bool getEquilateral(double a, double b, double c) {
		return a == b && b == c && c == a;
	}
	
	static bool getIsosceles(double a, double b, double c) {
		return a == b || a == c || b == c;
	}
	
	static double getHypotenuse(double a, double b) {
		return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
	}
}