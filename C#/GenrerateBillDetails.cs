using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgFundamentals2  //DO NOT change the namespace name
{
    public class Program      //DO NOT change the class name
    {
        public static void Main(string[] args)     //DO NOT change the 'Main' method signature
        {
            //Implement the code here
            Console.Write("Enter the number of pizzas bought:");
            int pizza = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the number of puffs bought:");
            int puffs = Convert.ToInt32(Console.ReadLine());
            Console.Write("\nEnter the number of pepsi bought:");
            int pepsi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\nBill Details\n");
            Console.WriteLine("Cost of Pizzas:{0}",(pizza*200));
            Console.WriteLine("Cost of Puffs:{0}",(puffs*40));
            Console.WriteLine("Cost of Pepsis:{0}",(pepsi*120));
            int total = (pizza * 200) + (puffs * 40) + (pepsi * 120);
            Console.WriteLine("GST 12%:{0}", (total*0.12));
            Console.WriteLine("CESS 5%:{0}", (total * 0.05));
            Console.WriteLine("Total Price:{0}",(total));



        }

    }
}