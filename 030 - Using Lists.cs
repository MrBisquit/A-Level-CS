using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		List<string> strList = new();
		
		strList.Add("Monday");
		strList.Add("Tuesday");
		string[] days = { "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };
		strList.AddRange(days);
		OutputList(strList);
		strList.Remove("Wednesday");
		OutputList(strList);
		days.Sort();
		OutputList(strList);
	}
	
	public static void OutputList(List<string> strList)
	{
		Console.WriteLine("There are {0} items in the list", strList.Count);
		Console.WriteLine("-----------------------------------------");
		foreach(string value in strList)
		{
			Console.WriteLine(value);
		}
		Console.WriteLine("");
	}
}