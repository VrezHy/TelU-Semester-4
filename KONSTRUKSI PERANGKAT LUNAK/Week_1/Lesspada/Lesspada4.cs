using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace DemoApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            //if
            Int32 value = 11;

            if (value < 10)
            {
                Console.WriteLine("Value is less than 10");
            }
            else
            {
                Console.WriteLine("Value is greater than 10");
            }

            //switch 
            Int32 value2 = 11;
            switch (value2)
            {
                case 1:
                    Console.WriteLine("Value is 1");
                    break;
                case 2:
                    Console.WriteLine("Value is 2");
                    break;
                default:
                    Console.WriteLine("value is different");
                    break;
            }

            //While
            Int32 value3 = 3, i = 0;

            while (i < value3)
            {
                Console.WriteLine(i);
                i = i + 1;
            }
                Console.WriteLine();

            //For
            for (Int32 f = 0; f < 3; f++)
            {
                Console.WriteLine(f);
            }

            Console.ReadKey();
        }
    }
}