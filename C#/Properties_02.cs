using System;
using System.Security.Authentication;

public class dataEmployee
{
    private int empid;
    private string empname;
    public int empsalary;
    public int employeeid
    {
        set{
            this.empid = value;
        }
        get{
            return this.empid;
        }
        
    }
    public string employeename
    {
        set
        {
            this.empname = Convert.ToString(value);
        }
        get
        {
            return this.empname;
        }
    }
    public dataEmployee(string Name, int empsalary)
    {
       this.employeename = Name;
        this.empsalary = empsalary;
    }
    public dataEmployee(int id)
    {
        this.employeeid = id;
    }

}
public class showEmpData
{
    static int Main()
    {
        dataEmployee emp1 = new dataEmployee("Dinesh", 20000);
        dataEmployee _emp1 = new dataEmployee(20);
        Console.WriteLine("Id = " + _emp1.employeeid);
        Console.WriteLine("Name = " + emp1.employeename);
        Console.WriteLine("Salary = " + emp1.empsalary);
        Console.ReadKey();
        return 0;
    }
}