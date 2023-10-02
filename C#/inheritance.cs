using System;
using System.Security.Cryptography.X509Certificates;

public class numbers{
    public int x = 10;
    public int y = 20;
}
public class sum : numbers
{
    public int z;
}
public class test
{
    static int Main()    {

        sum obj = new sum();
         obj.z= obj.x+obj.y;
        Console.WriteLine(obj.z);
         
        return 0;
    }

}