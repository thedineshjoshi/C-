using System;
public class Counter
{
    static int count;
    string name;
    string age;
    string weight;
    string guardian_name;
        static Counter()
    {
        count = 0;
        count++;
    }
    void get_data()
    {
        Console.Write("\t" + count);
        Console.WriteLine("Enter the Name of Student: ");
        name = Console.ReadLine();
        Console.WriteLine("Age = ");
        age = Console.ReadLine();
        Console.WriteLine("Weight = ");
        weight = Console.ReadLine();
        Console.WriteLine("Guardian Name = ");
        guardian_name = Console.ReadLine();

    }
    static int Main()
    {
        Console.WriteLine("Enter the data of student");
        Counter obj1 = new Counter();
        obj1.get_data();
        Counter obj2 = new Counter();
        obj2.get_data();
        Console.ReadKey();
        return 0;
    }

}