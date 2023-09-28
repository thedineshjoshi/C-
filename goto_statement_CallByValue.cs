using System;
using System.Diagnostics.CodeAnalysis;

public class gotoStatement
{
     int a,b,sum,mul,diff,div;
     void Add(int a,int b)
    {
        sum = a + b;
        Console.WriteLine(sum);
    }
    void multiply(int a, int b)
    {
        mul = a * b;
        Console.WriteLine(mul);
    }
    void division(int a, int b)
    {
        div = a / b;
        Console.WriteLine(div);
    }
    void difference(int a, int b)
    {
        diff = a - b;
        Console.WriteLine(diff);
    }
    static void Main()
    {

        gotoStatement operation = new gotoStatement();
        menu:
        Console.WriteLine("Calculator");
        Console.WriteLine("***********");
        Console.Write("Enter the value of a: \t");
        Console.WriteLine("");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter the value of b: \t");
        Console.WriteLine("");
        int b = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Choose:\n---------\nA --->Addition\nS --->Subtraction\nD--->Division \n M -----> Multiplication \n H---->Terminate the Program");
        Console.WriteLine("");
        string c = Convert.ToString(Console.ReadLine());
        if(c=="A")
        {
            operation.Add(a, b);
            goto menu;
        }
        else if (c == "S")
        {
            operation.difference(a, b);
            goto menu;
        }
        else if (c == "D")
        {
            operation.division(a, b);
            goto menu;
        }
        else if (c == "M")
        {
            operation.multiply(a, b);
            goto menu;
        }
        else if(c=="H")
        {
            Console.WriteLine("Thanks for using calculator...");
            goto exit;
            
        }
        else
        {
            Console.WriteLine("Please choose Correct Option \n");
            goto menu;
        }
    exit:
        Console.WriteLine("Thanks for using calculator");
    }
}