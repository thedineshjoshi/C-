using System;
public class Enumexample
{
    enum Months
    {
        January,
        Feburuary,
        March,
        April,
        May,
        June,
        July,
        August,
        September,
        November,
        December
    }
    static int Main()
    {
        int a = Convert.ToInt32(Months.January);
        int b = Convert.ToInt32(Months.May);
        Console.WriteLine("January = " + a);
        Console.WriteLine("May = " + b);
        Console.ReadKey();
        return 0;
    }
}