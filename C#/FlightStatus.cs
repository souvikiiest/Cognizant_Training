using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateEx2         //DO NOT CHANGE the namespace name
{
    public class Program   //DO NOT CHANGE the class name
    {
        /*** Dictionary values are hard-coded. Do NOT change ****/
        static Dictionary<string, DateTime> flightSchedule = new Dictionary<string, DateTime>(){
                                                        {"ZW346", Convert.ToDateTime("13:54:10")},
                                                        {"AT489", Convert.ToDateTime("16:30:00")},
                                                         {"BR267", Convert.ToDateTime("21:15:30")}};
                                       
        
        public static void Main(string[] args)   //DO NOT CHANGE the 'Main' method signature
        {
            //Implement your code here
            
            
        string flight;
        Console.WriteLine("Enter the Flight Number : ");
        flight=Console.ReadLine();
        Console.WriteLine(flightStatus(flight));

        }  

        public static string flightStatus(string fNo) //DO NOT CHANGE the 'flightStatus' method signature
        {
            
            //Implement your code here
            if (!flightSchedule.ContainsKey(fNo))
        {
            return "Invalid Flight Number";
        }
        DateTime deptTime = flightSchedule[fNo];
        if (DateTime.UtcNow < deptTime)
        {
            TimeSpan ts = deptTime.Subtract(DateTime.UtcNow);
            return "Time To Flight" + " " + ts.ToString();
        }
        else
        {
            return "Flight Already Left";
        }
            
        }

    }
}

