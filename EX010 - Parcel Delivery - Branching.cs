using System;
using System.Globalization;
					
public class Program
{
	public static void Main()
	{
		Console.Write("What is the weight of your parcel? (kg): ");
		float weight = float.Parse(Console.ReadLine());
		Console.Write("What is the volume of your parcel? (m3): ");
		float volume = float.Parse(Console.ReadLine());
		
		float cost = 0f;
		
		if(weight < 4f && volume < 0.3f) {
			cost = 5f;
		} else {
			float cost_a = 2f * weight;
			float cost_b = 20f * volume;
			
			cost = cost_a > cost_b ? cost_a : cost_b;
		}
		
		string str = cost.ToString("C", new CultureInfo("en-GB"));
		Console.WriteLine($"Thank you for using our service to send a parel weighing {weight} kg" +
						 $",\nwith a volume of {volume} m3.\nThe total cost for your delivery will be" +
						 $" {str}");
	}
}