using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Консоль5
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 11, b = 4;
            int max = b > a ? b : a;
            Console.WriteLine("Максимальное из чисел " + a + " и " + b + " это " + max);
            Console.ReadLine();
        }
    }
}
