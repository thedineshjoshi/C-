using System;
public class Continue
{
    static void Main()
    {
        int i, j;
        for(i = 1; i < 10; i++)
        {
            if(i == 7)
            {
                continue;
            }
            Console.WriteLine(i);
        }
        Console.ReadKey();
    }
}