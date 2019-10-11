using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6CS
{
    class Ejercicio1
    {
        static void Tabla(int n)
        {
            Console.WriteLine("Ingrese una numero");
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine(i + "*" + n + "=" + i * n);
            }
        }
        static void Main(string[] args)
        {
            int n;
            for (int x = 0; x < 10; x++)
            {
                Console.WriteLine("Ingrese la tabla de multiplicar a generar");
                n = int.Parse(Console.ReadLine());
                Tabla(n);
                Console.ReadKey();
            }
        }
    }
}
