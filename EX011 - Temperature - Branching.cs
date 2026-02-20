using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Please enter a temperature reading: ");
		float reading = float.Parse(Console.ReadLine());
		
		bool heater = false, amber = false, red = false;
		if(reading == 95 && reading != 97.500) heater = true;
		if(reading >= 98.100 && (reading < 95 || reading > 97.500)) red = true;
		if(reading < 95 || reading > 97.500) amber = true;
		
		Console.WriteLine($"Heater = {(heater ? "ON" : "OFF")} Amber Light = {(amber ? "ON" : "OFF")} Red Light = {(red ? "ON" : "OFF")}");
	}
}