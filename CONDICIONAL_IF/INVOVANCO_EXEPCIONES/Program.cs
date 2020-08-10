using System;
using System.Reflection.Metadata.Ecma335;

namespace INVOVANCO_EXEPCIONES
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce el numero del mes");
            int NumeroMes = int.Parse(Console.ReadLine());
            try 
            { 
                Console.WriteLine(NombreDelMes(NumeroMes));      /* Uso el metodo dentro del write */
            }
            catch(Exception ex)
            {
                Console.WriteLine($"Mensaje de la exepcion: {ex.Message}");
            }
            Console.WriteLine("Aqui continuaria la ejecucion del programa");
        }
        public static string NombreDelMes(int mes) 
        {
            switch (mes)
            {
                case 1:
                    return "Enero";
                case 2:
                    return "Febrero";
                case 3:
                    return "Marzo";
                case 4:
                    return "Abril";
                case 5:
                    return "Mayo";
                case 6:
                    return "Junio";
                case 7:
                    return "Julio";
                case 8:
                    return "Agosto";
                case 9:
                    return "Septiembre";
                case 10:
                    return "Octubre";
                case 11:
                    return "Noviembre";
                case 12:
                    return "Diciembre";

                default:
                    throw new ArgumentOutOfRangeException();   /* Invocando una exepcion*/
                         
            }

        }
    }
}
