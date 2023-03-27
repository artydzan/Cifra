using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public static class Extention
    {
        public static int Sum(int a, int b)
        {
            return a + b;
        }
        public static void PrintVar( string title, string variable)
        {
            Console.WriteLine("--------------------------------");
            Console.WriteLine($"{title}     {variable}");
            Console.WriteLine("--------------------------------");
        }
    }
}
