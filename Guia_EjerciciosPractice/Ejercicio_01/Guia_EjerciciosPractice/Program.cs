using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Guia_EjerciciosPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 01";
            int numero;
            int acumulador = 0;
            int numeroMayor = 0;
            int numeroMenor = 0;
            float promedio = 0;

            for(int i=0;i<5; i++)
            {
                Console.Write("\nIngrese un numero: ");
                numero = int.Parse(Console.ReadLine());

                acumulador += numero;

                if(i==0 || numero > numeroMayor)
                {
                    numeroMayor = numero;
                }
                if(i==0 || numero < numeroMenor)
                {
                    numeroMenor = numero;
                }

            }
            promedio = (float)acumulador / 5;
            Console.WriteLine("Mayor: {0}",numeroMayor);
            Console.WriteLine("Menor: {0}",numeroMenor);
            Console.WriteLine("Promedio: {0}",promedio);
            Console.ReadKey();

        }
    }
}
