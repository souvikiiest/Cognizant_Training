using System;

public class Program      //DO NOT change the class name
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the value for x");
        int x=Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Enter the value for y");
        int y=Convert.ToInt32(Console.ReadLine());
        bool isTrue= x<y;
        Console.WriteLine("The result of whether {0} is less than {1} is {2}",x,y,isTrue);
    }
    //implement code here
}
