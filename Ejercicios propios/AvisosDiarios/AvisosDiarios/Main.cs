using System;

namespace AvisosDiarios
{
    class Program
    {
        static void Main(string[] args)
        {
            AvisosTrafico Aviso1 = new AvisosTrafico(); // Al no pasarle ningun parametro se usa el constructor por defecto
            Aviso1.mostrarAviso();
            Console.WriteLine(Aviso1.mostrarFecha());
            AvisosTrafico Aviso2 = new AvisosTrafico("Jefatura provincial madrid",
                "Sancion de velocidad: 300$", Convert.ToDateTime("02/05/2019 12:10:15 PM"));   // Usando una fecha escrita por mi
            Aviso2.mostrarAviso();
            Console.WriteLine(Aviso2.mostrarFecha());
            
        }
    }
}
