using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6CS
{
    class Ejercicio4
    {
        static decimal Bin(decimal num)
        {
            if (num < 2)
            {
                return num;
            }
            else
            {
                return num % 2 + (10 * Bin(num / 2));
            }
        }
        static void Main(string[] args)
        {
            decimal num;
            Console.WriteLine("Ingrese el muneroque convertira a binario");
            num = Convert.ToDecimal(Console.ReadLine());
            Console.Clear();
            Console.WriteLine("El numero binario es: " + (Bin(num)));
            Console.ReadKey();
        }
    }
}

 
