using System;
public class CallByRefrence
{
    int a, b, c;
    void swap(ref int a,ref int b)
    {
        c = a;
        a = b;
        b = c;
        Console.WriteLine("After Swapping");
        Console.WriteLine("A = " + a);
        Console.WriteLine("B = " + b);

    }
    static void Main()
    {
        Console.WriteLine("\t Welcome To Swapping Program");
        Console.WriteLine("*********************************");
        Console.WriteLine("Enter the Value of A : \t");
        int d = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the Value of B : \t");
        int e = Convert.ToInt32(Console.ReadLine());
        CallByRefrence obj = new CallByRefrence();
        obj.swap(ref d, ref e);
        Console.ReadKey();


    }
}