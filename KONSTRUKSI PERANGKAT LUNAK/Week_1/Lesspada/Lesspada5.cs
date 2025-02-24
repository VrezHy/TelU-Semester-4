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
            Int32[] value;
            value = new Int32[3];

            value[0] = 1;
            value[1] = 2;
            value[2] = 3;

            Console.WriteLine(value[0]);
            Console.WriteLine(value[1]);
            Console.WriteLine(value[2]);

            Console.ReadKey();
        }
    }
}