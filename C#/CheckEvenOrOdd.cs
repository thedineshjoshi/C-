using System;

public class EvenOrOdd
{
    public static void Main()
    {
        Console.WriteLine("Enter a Number: \t");
        int x;
        x = Convert.ToInt32(Console.ReadLine());
        if(x%2==0)
        {
            Console.WriteLine(x + " is Even Number...");
        }
        else
        {
            Console.WriteLine(x + " is Odd Number");
        }
        Console.ReadKey();
            
    }
}
