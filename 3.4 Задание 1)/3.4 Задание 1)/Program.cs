using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3._4_Задание_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x = 0.1;
            double y;
            for(double i = x; i <= 3.0; i+= 10) 
            { 
                y = Math.Pow(i,2) + 4 * Math.Sin(Math.PI * i);
                Console.WriteLine(y);
            }
            Console.ReadKey();
        }
    }
}
