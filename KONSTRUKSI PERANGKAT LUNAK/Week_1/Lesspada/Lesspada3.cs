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
            String message = "The value is ";
            Int32 val = 30;

            Console.WriteLine(message + val);
            Console.WriteLine();
            //Console.ReadKey();


            Int32 val1 = 10, val2 = 20;
            bool status = true;

            Console.WriteLine(val1 + val2);
            Console.WriteLine(val1 < val2);
            Console.WriteLine(!(status));
            Console.ReadKey();
        }
    }
}