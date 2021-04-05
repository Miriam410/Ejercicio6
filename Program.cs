using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio6
{
    class Program
    {
        static void Main(string[] args)
        {
            // 6. Lea las teclas presionadas y finalice al presionar Shift+ Ctrl+ F
            ConsoleKeyInfo tecla;
            do
            {
                Console.WriteLine("Ingrese una tecla");
                char letra = Convert.ToChar(Console.ReadLine());
                Console.WriteLine($"Usted ha presionado la tecla  {letra} ");
                Console.WriteLine("Para finalizar presione Shift + Ctrl + F");
                tecla = Console.ReadKey();
                if (((tecla.Modifiers & ConsoleModifiers.Shift)!=0) &&
                    ((tecla .Modifiers & ConsoleModifiers.Control)!=0) &&
                        (tecla.Key == ConsoleKey.F))
                {
                    break;
                }
            } while(true);
        }
    }
}
