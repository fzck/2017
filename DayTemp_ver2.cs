using System;

class DaysTemp
{
    public int High{get; set;}
    public int Low{get; set;} // Declare the instance fields
    public int Average() // Declare the instance method
    {
    return (High + Low) / 2;
    }
}


public class Test
{
	public static void Main()
	{
		// your code goes here
		
		DaysTemp d1 = new DaysTemp();
		DaysTemp d2 = new DaysTemp();
		
		d1.High = 100;
		d1.Low = 0;
		
		Console.WriteLine("T = {0}, {1}, {2}", d1.Low, d1.High, d1.Average());
	}
}
