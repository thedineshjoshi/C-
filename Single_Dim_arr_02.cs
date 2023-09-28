using System;
public class subtraction_using_array
{

    static void Main()
    {
        int[] a = new int[5];
        Console.WriteLine("Enter the 5 numbers: ");
        for (int i = 0; i < 5; i++)
        {

            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("After Subtracting 5 from each number, the number becomes");
        for (int i = 0; i < 5; i++)
        {

            Console.WriteLine(a[i] - 5);
        }
        Console.ReadKey();
    }
}