using System;

public class Program      //DO NOT change the class name
{
    public static void Main(string[] args)
    {
    //implement code here
    Console.WriteLine("Enter large number 1:");
    long num1=long.Parse(Console.ReadLine());
    Console.WriteLine("Enter large number 2:");
    long num2=long.Parse(Console.ReadLine());
    long sum=num1+num2;
    Console.WriteLine("The result is: {0}",sum);

    }
    
        
}

