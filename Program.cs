using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World");
            int i, j, k = 0;
            // short j; then we will conver to INt16 if long then TOINt62
            Console.WriteLine("Enter the value for i");
            i = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for j");
            j = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter 1 to add \n2 to subtract \n3 multiply \n4 divide \n5 exit");
            int choice = Convert.ToInt32(Console.ReadLine());


            switch (choice)
            {
                case 1:
                    k = i + j;
                    break;
                case 2:
                    if (i != 0)
                        k = i - j;
                    break;
                case 3:
                    k = i * j;
                    break;
                case 4:
                    if (j != 0)
                        k = i / j;
                    break;
                case 5:
                    Environment.Exit(1);
                    break;

            }
            Console.WriteLine("The answer is " + k);
            Console.ReadLine();
        }
    }
}
