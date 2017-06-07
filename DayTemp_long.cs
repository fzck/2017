using System.IO;
using System;



class DaysTemp
{
    private int high, low; // Declare the instance fields
    
    public int High{
        get{
            return high;
        }set{
            high = value;
        }
    }
    public int Low{
        get{
            return low;
        } set {
            low = value;
        }
    
    }
    
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
		// d2 = new DaysTemp();
		
		d1.High = 100;
		d1.Low = 0;
		
		
		Console.WriteLine("T = {0}, {1}, {2}", d1.Low, d1.High, d1.Average());
	}
}

