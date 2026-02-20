using System;
using System.Collections;
					
public class Program
{
	public static void Main()
	{
		Queue myQueue = new();
		
		myQueue.Enqueue(99);
		myQueue.Enqueue(2);
		myQueue.Enqueue(22);
		myQueue.Enqueue(45);
		myQueue.Enqueue(4);
		myQueue.Enqueue(22);
		myQueue.Enqueue(22);
		myQueue.Enqueue(11);
		myQueue.Enqueue(1);
		
		foreach(int i in myQueue.ToArray())
			Console.WriteLine(i.ToString());
		
		Console.WriteLine("Number of elements in Queue: {0}", myQueue.Count);
	}
}