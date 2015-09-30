using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            string salida="1";
            Console.ForegroundColor = ConsoleColor.Cyan;
            //Console.BackgroundColor = ConsoleColor.White;
            Console.Title = "Title";
            Console.Beep();
            do
            {
                if (salida == "1")
                {
                    for (int i = 1; i <= 3; i++)
                    {
                        Console.WriteLine("Hola Mundo");
                    }
                }
                else
                    Console.WriteLine("Que quieres Hacer?");
                
                Console.WriteLine("Quieres salir? SI/NO");
                salida = Console.ReadLine();
            } while (salida.ToUpper() != "SI");
        }
    }
}
