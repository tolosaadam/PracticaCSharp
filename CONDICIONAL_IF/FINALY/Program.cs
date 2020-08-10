using System;

namespace FINALY
{
    class Program
    {
        static void Main(string[] args)
        {
            System.IO.StreamReader archivo = null;    /* LEYENDO UN FICHERO USANDO FINALY */
            try
            {
                string linea;

                int contador = 0;

                string path = @"C:\Users\Notebook\Desktop\fichero.txt";

                archivo = new System.IO.StreamReader(path);

                while((linea = archivo.ReadLine()) != null)
                {
                    Console.WriteLine(linea);
                    contador++;

                }


            }
            catch(Exception ex)
            {
                Console.WriteLine("Error con la lectura del archivo");
            }
            finally
            {
                if (archivo != null) 
                {
                    archivo.Close();
                    Console.WriteLine("Conexion con el fichero cerrada");
                }
            }
            
        }


    }
}
