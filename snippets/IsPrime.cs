using System;
					
public class Program
{
	public static bool IsPrime(int num) {
		if(num < 2) return false;
		if(num % 2 == 0) return num == 2;
		
		for(int i = 3; i * i <= num; i += 2)
			if(num % i == 0) return false;
		
		return true;
	}
}