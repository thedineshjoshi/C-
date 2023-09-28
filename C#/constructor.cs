using System;
public class Area{
    int l=10,b=15;
    Area(int l,int b)
    {
        int A = (this.l)*(this.b);
        Console.WriteLine("The Area is "+A);
    }
    static void Main()
    {
        Area obj = new Area(5,6);
        Console.ReadKey(); 
    }
}