using System;
					
public class Program
{
	public static void Main()
	{
		string [, ,] timetables = {
			{
				{ "French", 			"German", 		"History" },
				{ "Geography", 			"History", 		"IT"	  },
				{ "Computer Science", 	"English", 		"Maths"   }
			},
			{
				{ "IT", 				"Spanish", 		"English" },
				{ "Food Technology", 	"History", 		"French"  },
				{ "Computer Science", 	"Geography", 	"French"  }
			}
		};
		
		Console.Write("Student ID: ");
		int id = int.Parse(Console.ReadLine());
		
		Console.Write("Period number: ");
		int period = int.Parse(Console.ReadLine());
		
		Console.Write("Day of the week: ");
		int day = int.Parse(Console.ReadLine());
		
		Console.WriteLine($"Subject: {timetables[id, period, day]}");
	}
}