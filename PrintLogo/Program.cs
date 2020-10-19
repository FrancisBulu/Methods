using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintLogo
{
    class Program
    {
        static void Main(string[] args)
        {
            #region MyRegion


            //string star = new string('*', 50);
            //Console.WriteLine("My name is Franck");
            //Console.WriteLine("I am learning c#");
            //Console.WriteLine("I think it's lot of fun");
            //Console.WriteLine(star);


            //Console.WriteLine("My name is Franck");
            //Console.WriteLine("I am learning c#");
            //Console.WriteLine("I think it's lot of fun");
            //Console.WriteLine(star);

            //Console.WriteLine("My name is Franck");
            //Console.WriteLine("I am learning c#");
            //Console.WriteLine("I think it's lot of fun");
            //Console.WriteLine(star);

            //Console.WriteLine("My name is Franck");
            //Console.WriteLine("I am learning c#");
            //Console.WriteLine("I think it's lot of fun");
            //Console.WriteLine(star
            #endregion

            Calculate(5, 20);
            Show("intec", 8, 56);
        }
        #region MyRegion


        // een methode maken buiten de methode "satic void main"
        //static void PrinLogo() // altijd in Pascal case geschreven
        //{
        //    string stat = new string('*', 50);
        //    Console.WriteLine("My name is Franck");
        //    Console.WriteLine("I am learning c#");
        //    Console.WriteLine("I think it's lot of fun");
        //}
        #endregion
        static void Calculate(int a, int b)
        {
            
            int resultat = a + b;
            Console.WriteLine("De resultaat is "+ resultat );
        }
        static void Show (String c, int a, int b)
        {
            Console.WriteLine($"The result is {a+b} {c}");
        }
    }
}
