using System;
					
public class Program
{
	public static void Main()
	{
		string memorableWord, forename, surname;
		
		Console.WriteLine("Account Generator - " +  DateTime.Now + "\n");
		
		bool errored = false;
		
		Console.Write("Forename: ");
		forename = Console.ReadLine();
		Console.Write("Surname: ");
		surname = Console.ReadLine();
		Console.Write("Memorable word (>6 characters): ");
		memorableWord = Console.ReadLine();
		
		if(forename.Length == 0) {
			Console.WriteLine("Error: The forename cannot be empty");
			errored = true;
		}
		
		if(surname.Length == 0) {
			Console.WriteLine("Error: The surname cannot be empty");
			errored = true;
		}
		
		if(memorableWord.Length <= 6) {
			Console.WriteLine("Error: The memorable word must be longer than 6 characters");
			errored = true;
		}
		
		if(errored)
			return;
		
		string username, password;
		username = $"{surname.Substring(0, 3)}{forename.Substring(forename.Length - 3, 3)}".ToLower();
		
		password = $"{memorableWord.Substring(0, 3)}{username[0]}{username[^1]}";
		password += memorableWord.Substring(memorableWord.Length / 2, 2);
		
		Console.WriteLine("\nYour username is: " + username);
		Console.WriteLine("Your password is: " + password);
	}
}