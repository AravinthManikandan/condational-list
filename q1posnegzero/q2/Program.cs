using System;

namespace q2
{
    class Program
    {
        static void Main(string[] args)
        {
            int a =Getinteger("enter the first  number");
            PrintMessage(a.ToString());
            int b =Getinteger("enter the second number");
            PrintMessage(b.ToString());
            if(a==b)
            {
                System.Console.WriteLine("equal");
            }
            else
            {
                System.Console.WriteLine("not equal");
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
