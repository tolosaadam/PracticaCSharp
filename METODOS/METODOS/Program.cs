using System;

namespace METODOS
{
    class Program
    {
        static void Main(string[] args)       // Void =  El metodo no devuelve nada  // Siempre es el punto de entrada
        {
            mensajeEnPantalla();   // Los metodos se llaman dentro del metodo "MAIN" que es lo que lee el programa
            
            Console.WriteLine("Mensaje desde el main"); // Se escribe luego de llamar al metodo

            sumaNumeros(7,9);
        
        
        }
        
        static void mensajeEnPantalla()    //No va  ;   // Los metodos se escriben en paralelo al MAIN
        {

            Console.WriteLine("Mensaje desde el metodo 'mensaje en pantalla'");

        }
        
        static void sumaNumeros(int num1, int num2)
        {
            Console.WriteLine("La suma de los numeros es: " + (num1 + num2));
            Console.WriteLine($"La suma de los numeros es: {num1+num2}");   // Otra forma parecida al format


        }

    }
}
