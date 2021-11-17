using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoadValidator    //Do not change the namespace
{
    public class Program      //Do not change the class name
    {
        static void Main(string[] args)       //Do not change the method signature
        {
            //Implement code here  
            
            Console.WriteLine("Enter the number of people");
            int noOfPeople=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the total load in the elevator");
            int totalLoad=Convert.ToInt32(Console.ReadLine());
            
            bool isLoad=Validator.ValidateElevatorLoad(totalLoad,noOfPeople);
            
            if(isLoad){Console.WriteLine("Ready to go");}
            else {Console.WriteLine("Maximum load exceeded");}
            
            
        }
    }
    public class Validator       //Do not change the class name
    {
        public static bool ValidateElevatorLoad(int elevatorLoad, int noOfPeople)    //Do not change the method signature
        {
            //Implement code here
            
            if(elevatorLoad<1400&&noOfPeople!=0){return true;}
            else{return false;}
            
            
            
        }
    }

}
