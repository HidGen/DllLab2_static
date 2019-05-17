using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
using FirstDll;

namespace DLL_Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
              Console.Write("Введите x: ");
              double b = Convert.ToDouble(Console.ReadLine());
              Console.Write("Введите y: ");
              double result, c = Convert.ToDouble(Console.ReadLine());
            if ((b * c) >= 0)
            {
                 result = (Class1.Add(b, c));
            }
            else
            {
                 result = (Class1.Sub(b, c));
            }
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
