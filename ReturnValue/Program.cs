using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnValue
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int uitkomst = Add(10, 5); // x is locaal aan deze method
            if (uitkomst == 5)
            {
                Console.WriteLine("Operation is ok");

            }
            else
            {
                Console.WriteLine("There was a problem in your input");
            }
        }
        static int Add(int a, int b)// ( 10, 5)
        {
            int x = a + b; // 10 + 5 = 15
            Console.WriteLine(x);
            return x;
        }
    }
}
