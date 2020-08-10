using System;
using System.Collections.Generic;
using System.Text;


namespace CONCEPTOS_PO
{
    class Punto
    {
        private int x, y;
        private static int contadorDeObjetos = 0;   /* USANDO VARIABLES STATIC (SOLO PUEDE MODIFICARLA LA PROPIA CLASE
                                                     * NO LOS OBJETOS QUE CREO)
                                                     * Si en vez de static la defino como "constante" es lo mismo
                                                     * ya que c# ya sabe que es static */

        public Punto(int x, int y)
        {
            this.x = x;
            this.y = y;
            contadorDeObjetos++;                    /* Haciendo un contador de los objetos creados
                                                     * mediante la variable "static" que cree*/
        }
        public Punto()
        {
            this.x = 0;
            this.y = 0;
            contadorDeObjetos++;
        }
        public double calcularDistancia(Punto otroPunto)
        {
            int xDif = this.x - otroPunto.x;
            int yDif = this.y - otroPunto.y;
            double distanciaPuntos = Math.Sqrt(Math.Pow(xDif, 2) + Math.Pow(yDif, 2));  /*Metodo pitagoras*/
            return distanciaPuntos;
        }
        public static int contarObjetos()
        {
            return contadorDeObjetos;
        }
    }
}