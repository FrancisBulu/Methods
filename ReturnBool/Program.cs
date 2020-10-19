using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnBool
{
    class Program
    {
        static void Main(string[] args)
        {
            string wordOne = "Intec";
            string WordTwo = "Intec";

            bool test = CompareStrings(wordOne, WordTwo);
            if (test == true)
            {
                Console.WriteLine("The values are the same");

            }
            else
            {
                Console.WriteLine("The values are different");
            }
        }
        static bool CompareStrings(string stringOne, string stringTwo)
        {
            bool isEqual = true;
            if (stringOne.Length == stringTwo.Length)
            {
                for (int i = 0; i < stringOne.Length; i++)
                {
                    if (stringOne[i] != stringTwo[i])
                    {
                        isEqual = false;
                        break;
                    }
                }
                return isEqual;
            }
            else
            {
                
                isEqual = false;
                return isEqual;
            }
        }

    }
}
