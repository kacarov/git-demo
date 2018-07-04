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
          //  01.
            byte by = 97;
            sbyte sb = -115;
            short s = -10000;
            ushort us = 52130;
            uint ui = 4825932;
            Console.WriteLine("Byte: {0}, SByte: {1}, Short: {2}, UShort: {3}, Uint: {4}", by, sb, s, us, ui);

            //02.
            float fl = 12.345f;
            float fl2 = 3456.091f;
            double d = 34.567839023;
            double d2 = 8923.1234857;
            Console.WriteLine("Float1: {0}, Float2: {1}, Double1: {2}, Double2: {3}", fl, fl2, d, d2);

            //03.
            int var = 0xFE;
            Console.WriteLine(var);
           

            //04.
            char ch = '\u002A';
            char ch2 = (char)42;
        
            Console.WriteLine(ch +" "+ch2);

            //05.

            bool isFemale = false;

            Console.WriteLine(isFemale);

            //06.

            string hello = "Hello";
            string world = "World";
            object helloWorld = hello + " " + world;
            string result = (string)helloWorld;

            Console.WriteLine(result);

            //07.
            Console.WriteLine(@"The ""use"" of quotations difficulties.");
            Console.WriteLine("The \"use\" of quotations difficulties.");

            //08.
            Console.WriteLine("   @");
            Console.WriteLine("  @ @");
            Console.WriteLine(" @   @");
            Console.WriteLine("@ @ @ @");

            //09.

            int a = 5;
            int b = 10;

            Console.WriteLine("{0} {1}", a, b);

            int c = a;
            a = b;
            b = c;

            Console.WriteLine("{0} {1}", a, b);       

            // Console.WriteLine
            



            Console.ReadKey();
        }
    }
}
