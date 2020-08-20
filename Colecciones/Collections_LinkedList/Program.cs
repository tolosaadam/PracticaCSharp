using System;
using System.Collections.Generic;

namespace Collections_LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList<int> numeros = new LinkedList<int>();

            LinkedListNode<int> nodoImportante = new LinkedListNode<int>(15);  /* Creo un nodo de valor '15' */
            numeros.AddFirst(nodoImportante);                                   // Y lo agrego a la listay
            
            foreach(int num in new int[] { 10, 8, 6, 4, 2, 0 }) /* Uso un foreach para agregar numeros de un array que cree
                                                                 * dentro del foreach a la 'LinkedList' que inicialice antes "numeros" */
            {
                numeros.AddFirst(num);    /* 'AddFirst' Va agregando los valores en el primer valor de posicion del array, osea
                                           * que a medida que se van agregando nuevos valores, los que ya estaban van bajando
                                           * de posicion
                                           * 'AddLast' hace lo mismo pero al revez */
            }
            numeros.Remove(6);  //Removiendo el elemento '6' de la lista
            foreach(int num in numeros)
            {
                Console.WriteLine(num);
            }
        
            for(LinkedListNode<int> nodo = numeros.First; nodo != null; nodo = nodo.Next) /* Recorriendo  el array con objetos
                                                                                           * de tipo nodo
                                                                                           * (creando un nodo de nombre 'nodo'
                                                                                           * inicializandolo con el primer valor
                                                                                           * del array 'numeros.First'
                                                                                           * mientras que el nodo sea diferente de nulo
                                                                                           * el nodo en la otra vuelta del bucle va 
                                                                                           * a ser el siguiente nodo 'nodo.next' */
            {
                int num = nodo.Value;        /* Inicializo una variable con el valor del nodo donde esta parado en ese momento el bucle
                                              * 'nodo.Value' */
                Console.WriteLine(num);       // Para asi imprimirlo en pantalla
            }
        }
    }
}
