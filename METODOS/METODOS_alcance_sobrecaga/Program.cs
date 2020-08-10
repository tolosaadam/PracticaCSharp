using System;

namespace METODOS_alcance_sobrecaga
{
    class Program
    {
        int num1 = 5;        /* Si declaro las variables en el ambito de clase las puedo usar
                              * en cualquier metodo dentro de la clase  """Esto no tiene nada que ver
                              * con los ejercicios de abajo */
                            
           

        static void Main(string[] args)
        {
            Console.WriteLine(suma(7,5)); /* Depende cuantos argumentos pase y de que tipo
                                           * va a hacer referencia a un metodo"suma" diferente
                                           * por ejemplo este hace referencia al primer metodo suma
                                           * porque le pase solo 2  argumentos y de tipo int */

            
        }

        // SOBRECARGA DE METODOS (cuando hay 2 o mas con el mismo nombre)
        static int suma(int operador1, int operador2) => operador1 + operador2;

        /*static int suma(int numero1, int numero2) => numero1 + numero2;   Da error porque el metodo se llama igual
                                                                          * y tengo el mismo tipo y cantidad de argumentos*/

        static int suma(int operador1, int operador2, int operador3) => operador1 + operador2; /* No da error porque
                                                                                                * no tengo la misma
                                                                                                * cantidad de arguemntos*/

        static double suma(double operador1, int operador2) => operador1 + operador2; /* No da error porque no tengo
                                                                                       * el mismo tipo de parametros*/

    }

}
