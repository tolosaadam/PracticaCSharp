using System;

namespace METODOS_RETURN
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(sumaNumeros(7, 9));
            Console.WriteLine(divideNumeros(18, 6));
            Console.WriteLine(divideNumeros(18, 7));
            Console.WriteLine(divideNumeros2(20, 7));
        }

        static int sumaNumeros(int num1, int num2)
        {
            Console.WriteLine("La suma de los numeros es: " + (num1 + num2));
            Console.WriteLine($"La suma de los numeros es: {num1 + num2}");   // Otra forma parecida al format

            return num1 + num2;  // Cuando el codigo encuentra un return se sale del metodo


        }
        static double divideNumeros(double num1, double num2)  // Para decimales  
        {
            return num1 / num2;
            
        }

        static double divideNumeros2(double num1, double num2) => num1 /num2; /*Cuando solo tengo 1 linea se hace s/return
                                                                               * sin llave de apertura  y cierre*/


    }

}
