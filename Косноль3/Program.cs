using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Косноль3
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 3, y = 3;
            Console.Write("Значение префиксного выражения: ");
            Console.WriteLine(++x);
            Console.Write("Значение х после приращения: ");
            Console.WriteLine(x);

            Console.Write("Значение постфиксного выражения: ");
            Console.WriteLine(y++);
            Console.Write("Значение y после приращения: ");
            Console.WriteLine(y);
            Console.ReadLine();
        }
    }
}
