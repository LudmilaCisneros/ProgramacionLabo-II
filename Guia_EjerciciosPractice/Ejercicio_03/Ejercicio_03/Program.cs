using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_03
{
    class Program
    {
       
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 03";
            int numero;
            bool EsPrimo = false;

            Console.Write("Ingrese un numero: ");
            while (!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.Write("Error. Ingrese un numero: ");
            }
            while (numero <= 1)
            {
                Console.Write("Error. ingrese un numero mayor a 1: ");
                int.TryParse(Console.ReadLine(), out numero);
            }

            for (int i=2; i <= numero; i++)
            {
                EsPrimo = SaberSiEsPrimo(i);
                if (EsPrimo)
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadKey();

            bool SaberSiEsPrimo(int num)
            {
                bool esPrimo = true;

                for (int i = 2; i < num; i++)
                {
                    if (num % i == 0)
                    {
                        esPrimo = false;
                        break;
                    }

                }
                return esPrimo;
            }
        }

    }



}