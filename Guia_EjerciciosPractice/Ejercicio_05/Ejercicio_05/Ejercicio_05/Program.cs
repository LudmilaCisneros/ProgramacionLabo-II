using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Un centro numérico es un número que separa una lista de números enteros (comenzando en 1) en
dos grupos de números, cuyas sumas son iguales.
El primer centro numérico es el 6, el cual separa la lista (1 a 8) en los grupos: (1; 2; 3; 4; 5) y (7; 8)
cuyas sumas son ambas iguales a 15. El segundo centro numérico es el 35, el cual separa la lista (1 a
49) en los grupos: (1 a 34) y (36 a 49) cuyas sumas son ambas iguales a 595.
Se pide elaborar una aplicación que calcule los centros numéricos entre 1 y el número que el
usuario ingrese por consola.
Nota: Utilizar estructuras repetitivas y selectivas.*/
namespace Ejercicio_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 05";
            int prevSum;
            int postSum;
            int numero;

            Console.WriteLine("Ingrese hasta que numero desea calcular: ");
            while(!int.TryParse(Console.ReadLine(), out numero))
            {
                Console.WriteLine("ERROR, ingrese un numero valido: ");
            }

            //Itera hasta el numero ingresado.
            for (int i = 1; i <= numero; i++)
            {
                prevSum = 0;
                postSum = 0;

                //Suma todos los numeros anteriores positivos al indice
                for (int j = i - 1; j > 0; j--)
                {
                    prevSum += j;
                }

                //Suma los numeros posteriores al indice mientras la suma sea menor a la suma de los anteriores
                for (int j = i + 1; postSum < prevSum; j++)
                {
                    postSum += j;
                }

                //Prueba si la suma de los anteriores es igual a la suma de los posteriores.
                if (prevSum == postSum)
                {
                    Console.WriteLine("El numero {0} es centro numerico.", i);
                }
            }

            Console.ReadKey();
        }
    }
}
