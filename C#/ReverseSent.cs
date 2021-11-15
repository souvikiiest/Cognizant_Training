using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Hiworld
{
public class Program      //DO NOT change the class name
{
    //implement code here
    
    static void Main(string[] args)
    {   
       Console.WriteLine("Enter a string");
       string s=Console.ReadLine();
       string[] a = s.Split(' ');
       int k=a.Length-1;
       int temp=k;
       while(temp>=0)
       {
           Console.Write(a[temp]+""+' ');
           --temp;
       }
       
    }
}
}
