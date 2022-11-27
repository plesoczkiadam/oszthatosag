using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oszthatósag
{
    class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.WriteLine("Kérek 2 számot");
            Console.Write("a = ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("b= ");
            b = Convert.ToInt32(Console.ReadLine());
            if (a % b == 0)
            {
                Console.WriteLine("\nAz\"b\"osztoja\"a\"-nak ");
            }
            else 
            {
                if (b % a == 0)


                {
                    Console.WriteLine("\nAz \"a\" szám osztója \"b\"-bek");
                }
                else
                {
                    Console.WriteLine("Egyik szám sem osztója a másiknak ");
                }
            }
            Console.ReadLine();

        }
    }
}
