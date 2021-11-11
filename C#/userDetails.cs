using System;

public class Program      //DO NOT change the class name
{
    public static void Main(string[] args)
    {
       Console.WriteLine("Enter name");
       string name=Console.ReadLine();
       Console.WriteLine("Enter age(completed years and months");
       double age=Convert.ToDouble(Console.ReadLine());
       Console.WriteLine("Enter gender('M' for Male and 'F' for Female");
       char gender=Convert.ToChar(Console.ReadLine());
       Console.WriteLine("Enter city");
       string city=Console.ReadLine();
       Console.WriteLine("Enter mobile number");
       long mnumber=Convert.ToInt64(Console.ReadLine());
       Console.WriteLine("Enter pincode");
       int pin=Convert.ToInt32(Console.ReadLine());
       
      
      //Output starts here
      
      Console.WriteLine("Name:   {0}",name);
      Console.WriteLine("Age:    {0}",age);
      Console.WriteLine("Gender: {0}",gender);
      Console.WriteLine("City:   {0}",city);
      Console.WriteLine("Mobile: {0}",mnumber);
      Console.WriteLine("Pincode:{0}",pin);
      
    }
    //implement code here
}
