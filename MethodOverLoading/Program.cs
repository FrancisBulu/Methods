using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodOverLoading
{
    class Program
    {
        static void Main(string[] args)
        {
            Add(10, 30);
            Add(30, 80, 60);
        }
        static void Add(int firstNumber, int secondNumber)
        {
            Console.WriteLine($"The result firstNumber + secondNumber is {firstNumber+secondNumber }");
        }
        static void Add(int firstNumber, int secondNumber, int thirdNumber)
        {
            Console.WriteLine($"Result of firstNumber + secondNumber + thirdNumber is: {firstNumber+secondNumber+thirdNumber}");
        }
    }
}
