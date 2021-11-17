using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtractBookCode      //Do not change the namespace name
{
    public class Program      //Do not change the class name
    {
        public static void Main(String[] arg)         //Do not change the method signature
        {
            //Implement code here
            Console.WriteLine("Enter the book code of length 18");
            string bookCode=Console.ReadLine();
            if(bookCode.Length==18)
            {
                //Check for valid department code
                
                if(bookCode.Substring(0,3)=="101" || bookCode.Substring(0,3)=="102" ||  bookCode.Substring(0,3)=="103")
                {Console.WriteLine("Department Code:{0}",bookCode.Substring(0,3));}
                else{Console.WriteLine("Invalid Department code");}
                
                //Check for valid year
                
                int year=Convert.ToInt32(bookCode.Substring(3,4));
                if(year>=1900 && year<=2020)
                {Console.WriteLine("Year pf Publication:{0}",bookCode.Substring(3,4));}
                else{Console.WriteLine("Invalid Year");}
                
                //Check for valid Page Number
                
                long pageNo=Convert.ToInt64(bookCode.Substring(7,5));
                if(pageNo>=00001 && pageNo<=99999)
                {Console.WriteLine("Number of Pages:{0}",bookCode.Substring(3,4));}
                else
                {Console.WriteLine("Invalid Page Numbers");}
                
                //Check for valid BookID
                
                Char ch=Convert.ToChar(bookCode.Substring(12,1));
                if(Char.IsLetter(ch))
                {
                    if(Char.IsNumber(Convert.ToChar(bookCode.Substring(13,1)))&&Char.IsNumber(Convert.ToChar(bookCode.Substring(14,1)))&&Char.IsNumber(Convert.ToChar(bookCode.Substring(15,1)))&&Char.IsNumber(Convert.ToChar(bookCode.Substring(16,1)))&&Char.IsNumber(Convert.ToChar(bookCode.Substring(17,1))))
                    {
                        Console.WriteLine("Book ID:{0}",bookCode.Substring(12,6));
                    }
                    else
                    {Console.WriteLine("Invalid book ID");}
                    
                }
                else{Console.WriteLine("Invalid book ID");}
                
            }
            else{Console.WriteLine("Invalid bookcode");}
        }
    }
}