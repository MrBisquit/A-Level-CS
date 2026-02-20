using System;
					
public class Program
{
	public static void Main()
	{
		Book[] Library = new Book[7];
		
		Library[0].ISBN = "9781408855652";
		Library[0].Title = "The Philosopher's Stone";
		Library[0].Year = 1997;
		Library[0].Price = 4.99;
		
		Library[1].ISBN = "14088556666";
		Library[1].Title = "The Chamber of Secrets";
		Library[1].Year = 1998;
		Library[1].Price = 5.89;
		
		Library[2].ISBN = "1408855674";
		Library[2].Title = "The Prisoner of Azkaban";
		Library[2].Year = 1999;
		Library[2].Price = 5.36;
		
		Library[3].ISBN = "140855682";
		Library[3].Title = "The Goblet of Fire";
		Library[3].Year = 2000;
		Library[3].Price = 3.64;
		
		Library[4].ISBN = "9781408855690";
		Library[4].Title = "The Order of the Pheonix";
		Library[4].Year = 2003;
		Library[4].Price = 4.45;
		
		Library[5].ISBN = "9781408855706";
		Library[5].Title = "The Half-Blood prince";
		Library[5].Year = 2005;
		Library[5].Price = 8.69;
		
		Library[6].ISBN = "1408855712";
		Library[6].Title = "The Deathly Hallows";
		Library[6].Year = 2007;
		Library[6].Price = 6.54;
		
		for(int i = 0; i < Library.Length; i++)
			PrintBook(Library[i]);
	}
	
	public struct Book
	{
		public string ISBN;
		public string Title;
		public int Year;
		public double Price;
	}
	
	public static void PrintBook(Book record)
	{
		Console.WriteLine("ISBN:  " + record.ISBN);
		Console.WriteLine("Title: " + record.Title);
		Console.WriteLine("Year:  " + record.Year);
		if(record.Price > 5)
			Console.WriteLine("Price: " + record.Price);
		Console.WriteLine();
	}
}