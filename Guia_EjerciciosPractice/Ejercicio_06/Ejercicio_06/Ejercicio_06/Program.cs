using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
/*6. Escribir un programa que determine si un año es bisiesto.
Un año es bisiesto si es múltiplo de 4. Los años múltiplos de 100 no son bisiestos, salvo si ellos
también son múltiplos de 400. Por ejemplo: el año 2000 es bisiesto pero 1900 no.
Pedirle al usuario un año de inicio y otro de fin y mostrar todos los años bisiestos en ese rango.
Nota: Utilizar estructuras repetitivas, selectivas y la función módulo (%).*/

namespace Ejercicio_06
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 06";
            int hasta;
            int desde;
            
            //Input datos
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write(".::AÑO BISIESTO::.\n");
            Console.ForegroundColor = ConsoleColor.White;

            Console.Write("\nDesde: ");
            while (!int.TryParse(Console.ReadLine(), out desde))
            {
                Console.Write("Error, reingrese: ");
            }    

            Console.Write("\nHasta: ");
            while (!int.TryParse(Console.ReadLine(), out hasta))
            {
                Console.Write("Error, reingrese: ");
            }
            Console.Write("\n");
            CalcularBisiestos(desde,hasta);   
            Console.ReadKey();
        }
        public static void CalcularBisiestos(int desde, int hasta)
        {
            bool esBisiesto;

            for (int i=desde; i<=hasta; i++)
            {
                esBisiesto = false;

                if(i%4 == 0 || i%400 == 0)
                {
                    esBisiesto = true;
                }
                if(esBisiesto == true)
                {
                    Console.Write("{0}-",i);
                }

            }

        }
    }
}
