using System;


 namespace Methods2  //DO NOT change the namespace name
{
    public class Program      //DO NOT change the class name
    {
         public static void Main(string[] args)     //DO NOT change the 'Main' method signature
        {
           
            Console.WriteLine("Enter a Number");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Square of {0} is {1}",number,FindSquare(number));
            Console.WriteLine("Cube of {0} is {1}",number,FindCube(number));
        }
        public static double FindSquare(double num)
        {
            
            return num*num;
        }
        public static double FindCube(double num)
        {
            
            return num*num*num;
        }

    }
}