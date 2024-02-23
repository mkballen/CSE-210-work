using System;

class Program
{
    static void Main(string[] args)
    {
        //Console.WriteLine("Hello Learning04 World!");
        Assignment sa = new Assignment("Michael", "CSE210");
        System.Console.WriteLine(sa.GetSummary());

        MathAssignment ms = new MathAssignment("Gilbert Hart","physics","12.5", "1-10");
        System.Console.WriteLine(ms.GetSummary());
        System.Console.WriteLine(ms.GetMathAssignment());

        WritingAssignment wa = new WritingAssignment("Gilbert Hart","physics", "Kinematics");
        System.Console.WriteLine(wa.GetSummary());
        System.Console.WriteLine(wa.GetWritingInformation());
    }
}