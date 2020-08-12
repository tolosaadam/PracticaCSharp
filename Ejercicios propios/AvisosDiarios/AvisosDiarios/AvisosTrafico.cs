using System;
using System.Collections.Generic;
using System.Text;

namespace AvisosDiarios
{
    class AvisosTrafico : IAvisos
    {
        private string remitente;        //Campos de clase
        private string mensaje;
        //private string fecha;
        DateTime fecha;

        public AvisosTrafico()          //Constructor por defecto 
        {
            remitente = "Direccion general de trafico";
            mensaje = "Sancion cometida. Pague antes de 3 dias y se beneficiaria de una reduccion de la sancion del 50%";
            fecha = DateTime.Now;     //Usando la fecha actual por defcto 
        }
        
        public AvisosTrafico(string remitente, string mensaje, DateTime fecha) // Constructor personalizado
        {
            this.remitente = remitente;      //(this.remitente = campo de clase) (remitente=argumento del constructor)
            this.mensaje = mensaje;
            this.fecha = fecha;               // Uso fecha escrita por mi
        
        }
        public void mostrarAviso()
        {
            Console.WriteLine($"El mensaje {mensaje} a sido enviado por {remitente} en la fecha: {fecha}");
        }

        public DateTime mostrarFecha()
        {
            return fecha;
        }
    }
}
