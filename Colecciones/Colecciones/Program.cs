using System;
using System.Collections.Generic;
using System.Runtime.InteropServices.ComTypes;

namespace Colecciones
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Las colecciones tipo "List" nos permiten *Ordenar *Añadir *Eliminar *Buscar etc, elementos */

            List<int> numeros = new List<int>();   //Declarando una lista

            numeros.Add(5);
            numeros.Add(6);
            numeros.Add(7);

            int[] listaNumeros = new int[] { 3, 6, 8, 10, 50 };    // Array convencional

            for (int i = 0; i < 5; i++)
            {
                numeros.Add(listaNumeros[i]);   // Agregando a la lista los numeros que guarde antes en el array
            }


            for (int i = 0; i < numeros.Count ; i++)  //Recorro la lista y muestro los elementos del interior
            {
                Console.WriteLine(numeros[i]);
            }

            
            // AGREGANDO ELEMENTOS  POR PANTALLA 
            Console.WriteLine("Cuantos elementos quieres introducir?");
            int cantElem = int.Parse(Console.ReadLine());
            for(int i = 0; i < cantElem; i++)
            {
                Console.WriteLine($"Introduce el {i+1} elemento");
                numeros.Add(int.Parse(Console.ReadLine()));
            }
                Console.WriteLine("\nElementos introducidos: ");
            for (int i = 0; i < numeros.Count; i++)  //Recorro la lista y muestro los elementos del interior
            {
                Console.WriteLine(numeros[i]);
            }

            //USANDO FOR EACH CON COLLECTIONS "List"

            Console.WriteLine("Introduce elementos en la coleccion (escribe '0' para salir)");
            int condicion = 1;
            while(condicion != 0)
            {
                condicion = int.Parse(Console.ReadLine());
                numeros.Add(condicion);

            }

            numeros.RemoveAt(numeros.Count-1); /* Borramos el ultimo valor de la lista (para que no se vea el 0 de la condicion
                                                * del while ) */
            
            Console.WriteLine("Elementos introducidos: ");

            foreach(int elemento in numeros)
            {
                Console.WriteLine(elemento);
            }
        
        
        
        }
    }
}
