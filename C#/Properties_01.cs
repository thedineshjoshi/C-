using System;
public class Student
{
    private int stdid;
    private string name;
    private int age;
    private string fname;
    public int studentid
    {
        set
        {
            this.stdid = value;
        }
        get
        {
            return stdid;
        }

    }
}
public class Access
{
    static int Main()
    {
        Student obj = new Student();
        obj.studentid = 20;
        Console.WriteLine(obj.studentid);
        return 0;

    }
   
}