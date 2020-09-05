using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_07
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 07";
            int dia, mes, año, diasVividos;

            //INPUT
            /*
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("**::.¿CUÁNTOS AÑOS VIVISTE?.::**\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Ingresá tu fecha de nacimiento.<-");
            Console.ResetColor();

            Console.Write("Día: ");
            while (!int.TryParse(Console.ReadLine(), out dia))
            {
                Console.Write("Error, reingrese: ");
            }

            Console.Write("Mes: ");
            while (!int.TryParse(Console.ReadLine(), out mes))
            {
                Console.Write("Error, reingrese: ");
            }

            Console.Write("Año: ");
            while (!int.TryParse(Console.ReadLine(), out año))
            {
                Console.Write("Error, reingrese: ");
            }
            */
            dia = 12;
            mes = 1;
            año = 1997;
            diasVividos = CalcularDias(dia, mes, año);

            Console.WriteLine("-> Los días vividos son {0}", diasVividos);

            Console.ReadKey();
        }
        public static bool EsBisiesto(int año)
        {
            bool respuesta = false;


            if (año % 4 == 0 || año % 400 == 0)
            {
                respuesta = true;
            }


            return respuesta;
        }
        public static int CalcularDias(int dia, int mes, int año)
        {
            int contadorDias = 0;
            int añoActual = (int)DateTime.Now.Year;
            int mesActual = (int)DateTime.Now.Month;
            int diaActual = (int)DateTime.Now.Day;

            for (int i = año; i < añoActual; i++)
            {
                if (EsBisiesto(i))
                {
                    contadorDias += 366;
                }
                else
                {
                    contadorDias += 365;
                }
            }

            for (int i = mes; i < mesActual; i++)
            {
                switch (mes)
                {
                    case 2:
                        if (EsBisiesto(año))
                        {
                            contadorDias += 29;
                        }
                        else
                        {
                            contadorDias += 28;
                        }
                        break;

                    case 1://ENERO
                    case 3://MARZO
                    case 5://MAYO
                    case 7://JULIO
                    case 8://AGOSTO
                    case 10://OCTUBRE
                    case 12://DICIEMBRE
                        contadorDias += 31;
                        break;

                    case 4://ABRIL
                    case 6://JUNIO
                    case 9://SEPTIEMBRE
                    case 11://NOVIEMBRE
                        contadorDias += 30;
                        break;

                }

            }
            for (int i = 1; i < diaActual; i++)
            {
                contadorDias++;
            }


            return contadorDias;
        }
    }
}
