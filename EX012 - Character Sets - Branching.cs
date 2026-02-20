using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Please enter the EBCDIC value: ");
		int ebcdic = int.Parse(Console.ReadLine());
		
		// https://www.ibm.com/docs/en/iis/11.3.0?topic=tables-ebcdic-ascii
		if(ebcdic >= 129 && ebcdic <= 137)
			Console.WriteLine($"{(ebcdic - 32)}");	
		else if(ebcdic >= 145 && ebcdic >= 153)
			Console.WriteLine($"{(ebcdic - 106)}");

        // Not done yet
	}
}