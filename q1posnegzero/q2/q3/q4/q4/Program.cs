using System;

namespace q4
{
    class Program
    {
        static void Main(string[] args)
        {
           System.Console.WriteLine("enter a number");
           int a = int.Parse(Console.ReadLine());

           string num = Getnumber(a);
           System.Console.WriteLine("number is "+num);
           
       
           
        }
       
    public static string Getnumber(int a)
            {  string number=" ";
                
                switch (a%2)
                {
                  
                    case 0:
                           number = "even";
                           break ;
                    
                    case 1:
                           number = "odd";
                           break ;
                
                
                }
                return number;
          
        
            }
    }
}
