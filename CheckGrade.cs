using System;
public class CheckGrade
{
    static void Main()
    {
        Console.WriteLine("Enter your GPA");
        double GPA = Convert.ToDouble(Console.ReadLine());
        if(GPA>3.6&&GPA<=4.0)
        {
            Console.WriteLine("You have Secured A+ Grade --> \t Outstanding");
        }
        else
            if(GPA>3.2&&GPA<=3.6)
        {
            Console.WriteLine("You have Secured A Grade --> \t Excellent");
        }
        else
            if (GPA > 2.8 && GPA <= 3.2)
        {
            Console.WriteLine("You have Secured B+ Grade --> \t Very Good");
        }
        else
            if (GPA > 2.4 && GPA <= 2.8)
        {
            Console.WriteLine("You have Secured B Grade --> \t  Good");
        }
        else
            if (GPA > 2 && GPA <= 2.4)
        {
            Console.WriteLine("You have Secured C+ Grade --> \t Satisfactory");
        }
        else
            if (GPA > 1.6 && GPA <= 2)
        {
            Console.WriteLine("You have Secured C Grade --> \t Acceptable");
        }
        else
            if (GPA > 1.2 && GPA <= 1.6)
        {
            Console.WriteLine("You have Secured D+ Grade --> \t Partially Acceptable");
        }
        else
            if (GPA > 0.8 && GPA <= 1.2)
        {
            Console.WriteLine("You have Secured D Grade --> \t Insufficient");
        }
        else
            if (GPA > 0 && GPA <= 0.8)
        {
            Console.WriteLine("You have Secured E Grade --> \t Very Insufficient");
        }
        else
            if (GPA > 4)
        {
            Console.WriteLine("You have entered incorrect GPA...");
        }
        Console.ReadKey();
    }
}