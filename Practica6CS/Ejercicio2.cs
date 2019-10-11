using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica6CS
{
    class Ejercicio2
    {
        static void dibujo(int ancho, int alto)
        {
            for (int i = 0; i < ancho; i++)
            {
                for (int j = 1; j < alto; j++)
                {
                   Console.Write(" * ");
                } 

                Console.WriteLine(" *");
            }
        }
        static void dibujo(int ancho, int alto, char caracter)
        {
            for (int i = 0; i < ancho; i++)
            {
                for (int j = 1; j < alto; j++)
                {
                    Console.Write(" "+ caracter +" ");
                }

                Console.WriteLine(" ", caracter);
            }
        }
        static void dibujo(int ancho, int alto, char caracter, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            dibujo(ancho, alto, caracter);
        }
        static void Main(string[] args)
        {
            int ancho, alto, x, y;
            char caracter;

            Console.Write("Ingrese el ancho de la figura: ");
            int.TryParse(Console.ReadLine(), out ancho);
            Console.Write("Ingrese el alto de la figura: ");
            int.TryParse(Console.ReadLine(), out alto);
            Console.WriteLine("\nsu figura ha sido generada \n");
            dibujo(alto, ancho);
            Console.WriteLine("\nPresione <ENTER> para continuar");
            Console.ReadKey();

            Console.Clear();
            Console.Write("Ingrese el ancho de la figura: ");
            int.TryParse(Console.ReadLine(), out ancho);
            Console.Write("Ingrese el alto de la figura: ");
            int.TryParse(Console.ReadLine(), out alto);
            Console.Write("Ingrese el caracter a utilizar para dibujar la figura: ");
            char.TryParse(Console.ReadLine(), out caracter);
            Console.WriteLine("\nsu figura ha sido generada \n");
            dibujo(alto, ancho, caracter);
            Console.WriteLine("\nPresione <ENTER> para continuar");
            Console.ReadKey();

            Console.Clear();
            Console.Write("Ingrese el ancho de la figura: ");
            int.TryParse(Console.ReadLine(), out ancho);
            Console.Write("Ingrese el alto de la figura: ");
            int.TryParse(Console.ReadLine(), out alto);
            Console.Write("Ingrese el caracter a utilizar para dibujar la figura: ");
            char.TryParse(Console.ReadLine(), out caracter);
            Console.Write("Ingrese la coordenada X: ");
            int.TryParse(Console.ReadLine(), out x);
            Console.Write("\nIngrese la coordenada Y: ");
            int.TryParse(Console.ReadLine(), out y);
            Console.WriteLine("\nsu figura ha sido generada \n");
            dibujo(alto, ancho, caracter, x, y);
            Console.WriteLine("\nPresione <ENTER> para continuar");
            Console.ReadKey();
        }
    }
}
