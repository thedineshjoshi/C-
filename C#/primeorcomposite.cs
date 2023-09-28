using System;

public class Prime
{
    static void Main()
    {
        Console.WriteLine("Enter a number: \t");
        int n;
        int i;
        n = Convert.ToInt32(Console.ReadLine());
        if (n == 2)
        {
            Console.WriteLine("Number is Prime");
        }
        else
        {
            for (i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    Console.WriteLine("The number is Composite");
                    break;
                }
                else
                {
                    Console.WriteLine("The number is prime");
                    break;
                }
            }
        }
        Console.ReadKey();

    }
}