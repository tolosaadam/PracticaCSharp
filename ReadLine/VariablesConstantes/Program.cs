using System;


namespace VariablesConstantes
{
    class Program
    {
        static void Main(string[] args)
        {
            const int VALOR = 5;  /*const = variable consante y se le debe asignar un valor siempre en la misma linea
                                   * el nombre de las constantes por buena norma va en MAYUSCULAS */
            const int VALOR2 = 7;

            Console.WriteLine("El valor de la constante es: {0} y la constante2 es: {1}", VALOR, VALOR2);
            // El indice {0}  es VALOR y el indica {1}  es VALOR2

            
            // Calculando el area de un circulo
            const double PI = 3.1416;
            
            Console.WriteLine("Introduce la medida del radio");
            
            double radio = double.Parse(Console.ReadLine());

            //double area = radio * radio * PI;
            double area = Math.Pow(radio, 2) * PI;  // Utilizando la funcion Math.Pow (base al cuadrado)

            Console.WriteLine("El area del circulo es: {0}", area);













            







        }
    }
}
