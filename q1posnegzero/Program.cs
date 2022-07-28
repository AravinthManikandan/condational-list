using System;

namespace q1posnegzero
{
   
    class Program
    {

        static void Main(string[] args)
        {

            int a =Getinteger("enter a number");
            PrintMessage(a.ToString());
            if (a>0)
            {
                System.Console.WriteLine( "positive");  
            } 
            else if(a==0)
            {
                System.Console.WriteLine("zero");
            }
            else
            {
                System.Console.WriteLine("negative");
            }          
           
        }
            
        public static int Getinteger(string a)
            {
                PrintMessage(a);
                int temp = int.Parse(Console.ReadLine());
                return temp;

            }
        public static void PrintMessage(string Message)
            {
                System.Console.WriteLine(Message);
            }
      
            
        
        
    }
}
