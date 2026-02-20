using System;
					
public class Program
{
	public static void Main()
	{
        // Probably need to make a better version of this

		Console.Write("Enter binary number: ");
		char[] bin = Console.ReadLine().ToCharArray();
		
		int[] num = new int[bin.Length];
		for(int i = 0; i < bin.Length; i++) {
			num[i] = (2 ^ (i - 1)) + 1;
			Console.WriteLine(num[i].ToString());
		}
		
		int den = 0;
		for(int i = 0; i < bin.Length; i++) {
			den += (bin[i] == '1' ? num[(bin.Length - i - 1)] : 0);
		}
		
		Console.WriteLine("Denary value: " + den.ToString());
	}
}

// I think I found another version, it has the exact same name, but with different content
using System;
					
public class Program
{
	public static void Main()
	{
		Console.Write("Enter binary number: ");
		char[] bin = Console.ReadLine().ToCharArray();
		bin.Reverse();
		
		/*int[] num = new int[bin.Length];
		for(int i = 0; i < bin.Length; i++) {
			num[i] = (2 ^ (i - i)) + 1;
			Console.WriteLine(num[i].ToString());
		}*/
		
		int den = 0;
		for(int i = bin.Length; i > 0; i--) {
			Console.WriteLine($"{i} {Math.Pow(2, i - 1)} {(bin[i - 1] == '1' ? 1 : 0)}");
			den += (bin[i - 1] == '1' ? 1 : 0) * (int)Math.Pow(2, i - 1); // (bin[i] == '1' ? num[(bin.Length - i - 1)] : 0);
		}
		
		Console.WriteLine("Denary value: " + den.ToString());
	}
}