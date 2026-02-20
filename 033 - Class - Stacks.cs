using System;
using System.Collections;
					
public class Program
{
	public static void Main()
	{
		Stack myStack = new();
		
		myStack.Push(1);
		myStack.Push(11);
		myStack.Push(22);
		myStack.Push(22);
		myStack.Push(4);
		myStack.Push(45);
		myStack.Push(22);
		myStack.Push(2);
		myStack.Push(99);		
		
		foreach (int item in myStack)
			Console.WriteLine(item.ToString());
		
		Console.WriteLine("Number of elements in Stack: {0}", myStack.Count);
	}
}