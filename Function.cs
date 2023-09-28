using System;

public class functioncall
{
    void show()
    {
        Console.WriteLine("Enter all your Personal details");
        Console.WriteLine("********************************");
        Console.WriteLine("Full Name: \t");
        string name = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Fathe Name: \t");
        string Father = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Mother Name:\t");
        string Mother = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Enter your College Name: \t");
        string college = Convert.ToString(Console.ReadLine());
        Console.WriteLine("Thanks for information...");
    }
   static void Main()
    {
        functioncall Call = new functioncall();
        Call.show();
    }
    
}