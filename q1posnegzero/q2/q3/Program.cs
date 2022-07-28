using System;

namespace q3
{
    class Program
    {
        static void Main(string[] args)
        {
            float a =Getfloat("enter the first  number");
            PrintMessage(a.ToString());
            float b =Getfloat("enter the second number");
            PrintMessage(b.ToString());
            if(a==b)
            {
                System.Console.WriteLine("floating are equal");
            }
            else
            {
                System.Console.WriteLine("floating are not equal");
            }
            
        }
    public static float Getfloat(string a)
            {
                PrintMessage(a);
                float temp = float.Parse(Console.ReadLine());
                return temp;

            }
    public static void PrintMessage(string Message)
            {
                System.Console.WriteLine(Message);
            }
    }
}
