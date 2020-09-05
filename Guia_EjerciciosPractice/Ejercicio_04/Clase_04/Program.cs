using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase_04
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 04";
            bool respuesta = false;

            Console.Write("Bienvenido.. los primeros 4 números perfectos son: \n");

            for(int i=1;i<=8128; i++)
            {
                respuesta = EsPerfecto(i);

                if(respuesta == true)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("{0}",i);
                }
            }
            Console.ReadKey();
        }
        public static bool EsPerfecto(int numero)
        {
            bool respuesta = false;
            int acumulador = 0;

            for(int i=1 ;i<numero;i++)
            {
                if(numero%i == 0)
                {
                    acumulador += i;
                }
            }

            if(acumulador == numero)
            {
                respuesta = true;
            }

            return respuesta;
        }
    }
}
