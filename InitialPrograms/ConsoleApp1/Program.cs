using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string myName;
            Console.Write("Please enter your name and press enter :");
            myName = Console.ReadLine();
            string myValue = String.Format("Upper case:{0}", myName.ToUpper());
            Console.Write(myValue);
        }
    }
}