using System;

public class Single_Dimensional_array_01
{
    static void Main()
    {
        int[] a = new int[5];
        Console.WriteLine("Enter the values of array: ");
        for (int i=0;i<5;i++)
        {
            a[i]=Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Enter the values of array: ");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine(a[i]);
        }
        Console.ReadKey();

    }
}