using System;
using System.IO;
					
public class Program
{
	public static void Main()
	{
		string[] birds = {
			"Robin",
			"Magpie",
			"Chaffinch",
			"Eagle",
			"Thrush",
			"Sparrow",
			"Eagle",
			"Pigeon",
			"Eagle",
			"Swallow"
		};
		string filePath = "birds.txt";
		FileStream fileStream = new FileStream(filePath, FileMode.Create, FileAccess.Write);
		using (StreamWriter streamWriter = new StreamWriter(fileStream))
		{
			for(int i = 0; i < birds.Length; i++)
				streamWriter.WriteLine(birds[i]);
			streamWriter.Close();
		}
		int eagles = 0;
		FileStream fileStream2 = new FileStream(filePath, FileMode.Open, FileAccess.Read);
		using (StreamReader streamReader = new StreamReader(fileStream2))
		{
			string content;
			// ?
			while((content = streamReader.ReadLine()) != null)
			{
				if(content == "Eagle")
					eagles++;
			}
			streamReader.Close();
		}
		Console.WriteLine($"There were {eagles} eagles in the file");
	}
}