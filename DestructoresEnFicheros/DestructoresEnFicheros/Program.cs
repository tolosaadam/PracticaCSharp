using System;
using System.IO;

namespace DestructoresEnFicheros   // Los destructores son para liberar memoria 'Heap' de forma instanea
{
    class Program
    {
        static void Main(string[] args)
        {
            ManejoArchivos archivo1 = new ManejoArchivos();
            archivo1.mensaje();

        }
    }
    
    class ManejoArchivos
    {
        StreamReader archivo = null;   
        int contador = 0;
        string linea;
        public ManejoArchivos()    // Constructor 
        {
            archivo = new StreamReader(@"C:\Users\Adam\Desktop\FicheroDePrueba.txt"); //Sintaxis para leer un archivo

            while ((linea=archivo.ReadLine()) != null)  // Imprimiendo por pantalla cada linea dentro del archivo
            {
                Console.WriteLine(linea);
                contador++;
            }

        }
        public void mensaje()
        {
            Console.WriteLine($"hay {contador} cantidad de lineas");
        }

        ~ManejoArchivos()       // Sintaxis de destructor
        {
            archivo.Close();    /* La instruccion para cerrar la coneccion con el archivo, base  de datos, o elimina objetos
                                 * dentro de un array de objetos */
        }
    }
}
