using System;
					
public class Program
{
	public static void Main()
	{
		Account[] Bank = new Account[5];
		
		Bank[0].Name = "Rob";
		Bank[0].Address = "Rob's House";
		Bank[0].AccountNumber = 709831;
		Bank[0].Balance = 1_000;
		
		Bank[1].Name = "Jim";
		Bank[1].Address = "Jim's House";
		Bank[1].AccountNumber = 792754;
		Bank[1].Balance = 99;
		
		Bank[2].Name = "Sandy";
		Bank[2].Address = "Sandy's House";
		Bank[2].AccountNumber = 38245;
		Bank[2].Balance = 100_000;
		
		PrintAccount(Bank[2]);
		PrintAccount(Bank[1]);
		PrintAccount(Bank[0]);
	}
	
	public struct Account {
		public string Name;
		public string Address;
		public int AccountNumber;
		public int Balance;
	};
	
	public static void PrintAccount(Account record) {
		Console.WriteLine("Name: " + record.Name);
		Console.WriteLine("Address: " + record.Address);
		Console.WriteLine("Balance: " + record.Balance);
		Console.WriteLine("Account number: " + record.AccountNumber);
		Console.WriteLine();
	}
}