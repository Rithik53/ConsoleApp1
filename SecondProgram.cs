using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SecondProgram
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("I am secong program");
            AcceptData();

            Console.ReadLine();
        }

        public static void AcceptData()
        {
            Console.WriteLine("Enter a number");
            int no1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the 2nd number");
            int no2 = Convert.ToInt32(Console.ReadLine());
            object obj ;
            obj = no1;
            Console.WriteLine(obj.GetType());
            Console.WriteLine(obj);
        }
    }
}
