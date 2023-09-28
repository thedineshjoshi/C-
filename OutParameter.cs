using System;

public class OutParameter
{
    void OutFunction(out int a)
    {
        a = 0;
        a = a + 5;
    }
    static void Main()
    {
        int a = 15;
        Console.WriteLine("Value before calling the function is " + a);
        Console.WriteLine("Value after calling the function is:");
        OutParameter obj = new OutParameter();
        obj.OutFunction(out a);
        Console.WriteLine(a);


    }
}
