using System;
using System.Collections.Generic;
					
public class Program
{
	public static void Main()
	{
		List<Tuple<int, string, string>> listEmployee =
			new() {
			Tuple.Create<int, string, string>(1, "Joydip Kanjilal", "INDIA"),
			Tuple.Create<int, string, string>(2, "Michael Stevens", "USA"),
			Tuple.Create<int, string, string>(3, "Steve Barnes", "USA")
		};
		
		listEmployee.Add(Generate(4, "Karren Brady", "UK"));
		listEmployee.Add(Generate(5, "Alan Sugar", "UK"));
		listEmployee.Add(Generate(6, "Nick Hewer", "UK"));
		listEmployee.Add(Generate(7, "Margaret Mountford", "UK"));
		listEmployee.Add(Generate(8, "Claude Littner", "UK"));
		
		int uk = 0;
		foreach(Tuple<int, string, string> item in listEmployee) {
			if(item.Item3 == "UK")
				uk++;
			Console.WriteLine(item.Item2);
		}
		
		Console.WriteLine($"\nThere are {uk} employees from the UK");
	}
	
	public static Tuple<int, string, string> Generate(int i, string name, string country) {
		return Tuple.Create<int, string, string>(i, name, country);	
	}
}