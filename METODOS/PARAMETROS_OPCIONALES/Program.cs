using System;

namespace METODOS_parametros_opcionales
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 7;
            double valor2 = 5.2;
            double valor3 = 5.3;

            Console.WriteLine(Suma(valor1, valor2, valor3));
        }

        private static double Suma(int num1, double num2, double num3 = 0) /* el num3 es un parametro opcional
                                                                            * porque puedo pasarlo cuando llamo al metodo
                                                                            * o no llamarlo y sera 0 */
        {
            return num1 + num2 + num3;
        }
    }
}
