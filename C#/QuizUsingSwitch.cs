using System;
public class Quiz
{
    static void Main()
    {
        char num;
        Console.WriteLine("Welcome To Far-Western Universirty Quiz Contest");
        Console.WriteLine("1. Who developed C# Programming?\n");
        Console.WriteLine("A. Mark ZuckerBerg \t B. Tim Berner-Lee \t C. Bill Gates \t D. Andels Hejlsberg");
        num = Convert.ToChar(Console.ReadLine());
        switch (num)
        {
            case 'a':Console.WriteLine("Wrong");
                break;
            case 'b': Console.WriteLine("Wrong");
                break;
            case 'c': Console.WriteLine("Wrong");
                break;
            case 'd':Console.WriteLine("Right Answer");
                break;
            default: Console.WriteLine("Wrong Input");
                break;
        }
        Console.WriteLine("");
        Console.WriteLine("2. Who developed C Programming?\n");
        Console.WriteLine("A. Mark ZuckerBerg \t B. Danish Ritche \t C. Bill Gates \t D. Andels Hejlsberg");
        num = Convert.ToChar(Console.ReadLine());
        switch (num)
        {
            case 'a':
                Console.WriteLine("Wrong");
                break;
            case 'b':
                Console.WriteLine("Wright Answer");
                break;
            case 'c':
                Console.WriteLine("Wrong");
                break;
            case 'd':
                Console.WriteLine("Wrong");
                break;
            default:Console.WriteLine("Wrong Input");

                break;
        }
        Console.WriteLine("");
        Console.WriteLine("3. Who developed HTML? \n");
        Console.WriteLine("A. Mark ZuckerBerg \t B. Tim Berner-Lee \t C. Bill Gates \t D. Andels Hejlsberg");
        num = Convert.ToChar(Console.ReadLine());
        switch (num)
        {
            case 'a':
                Console.WriteLine("Wrong");
                break;
            case 'b':
                Console.WriteLine("Wright Answer");
                break;
            case 'c':
                Console.WriteLine("Wrong");
                break;
            case 'd':
                Console.WriteLine("Wrong");
                break;
            default:Console.WriteLine("Wrong Input");
                break;
        }
        Console.WriteLine("");
        Console.WriteLine("4. Who is the founder of facebook?\n");
        Console.WriteLine("A. Mark ZuckerBerg \t B. Tim Berner-Lee \t C. Bill Gates \t D. Andels Hejlsberg");
        num = Convert.ToChar(Console.ReadLine());
        switch (num)
        {
            case 'a':
                Console.WriteLine("Wright Answer");
                break;
            case 'b':
                Console.WriteLine("Wrong");
                break;
            case 'c':
                Console.WriteLine("Wrong");
                break;
            case 'd':
                Console.WriteLine("Wrong");
                break;
            default:Console.WriteLine("Wrong Input");
                break;
        }
        Console.WriteLine("");
        Console.WriteLine("5. Who developed Microsoft?\n");
        Console.WriteLine("A. Mark ZuckerBerg \t B. Tim Berner-Lee \t C. Bill Gates \t D. Andels Hejlsberg");
        num = Convert.ToChar(Console.ReadLine());
        switch (num)
        {
            case 'a':
                Console.WriteLine("Wrong");
                break;
            case 'b':
                Console.WriteLine("Wrong");
                break;
            case 'c':
                Console.WriteLine("Wright Answer");
                break;
            case 'd':
                Console.WriteLine("Wrong");
                break;
            default:Console.WriteLine("Wrong Input");
                break;
        }
        Console.ReadKey();
    }
}