using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6CS
{
    class Ejercicio3
    {
        static int ELevarBase(int n, int exp)
        {
            if (exp == 0)
            {
                return 1;
            }
            else
            {
                if (exp < 0)
                {
                    return ELevarBase(n, exp + 1) / n;
                }
                else
                {
                    return n * ELevarBase(n, exp - 1);
                }
            }
        }
        static void Main(string[] args)
        {
            int Base, Exponente;
            Console.WriteLine("Ingrese la base a elevar:");
            int.TryParse(Console.ReadLine(), out Base);
            Console.WriteLine("Ingrese el exponente:");
            int.TryParse(Console.ReadLine(), out Exponente);
            Console.Clear();
            Console.WriteLine("{0}^{1} es: {2}", Base, Exponente, ELevarBase(Base, Exponente));
            Console.ReadLine();
        }
    }
}
