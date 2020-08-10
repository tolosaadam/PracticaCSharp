using System;
using System.Numerics;

namespace CONSTRUCTORES
{
    class Program
    {
        static void Main(string[] args)
        {
            Coche coche1 = new Coche(); /* Creamos un objeto de tipo coche o instancia
                                         * Dimos un estado inicial a nuestro coche por medio del
                                         * constructor, todos tendran como estado inicial lo que haya en el instructor */
            Coche coche2 = new Coche();
            Console.WriteLine(coche1.getInfoCoche());
            Console.WriteLine(coche2.getInfoCoche());

            Coche coche3 = new Coche(4500.25,1200.35);  /* Como el segundo construstor me pide 2 parametros
                                                         * visualestudio deduce que estoy llamando al segundo constructor
                                                         * y no al primero */

            Console.WriteLine(coche3.getInfoCoche());
            coche3.setExtras(true, "cuero");             /* METODO SETTER */ 
            Console.WriteLine(coche3.getExtras());



        }
    }
    partial class Coche    /* DIVIENDO LA CLASE EN 2 PARTES PARA UN MEJOR MANEJO DE ERRORES Y PROGRAMACION 
                            * LA PRIMERA PARTE LOS CONSTRUCTORES, LA SEGUNDA PARTE LOS METODOS Y CAMPSO DE CLASE */
    {
        public Coche()   /* CONSTRUCTOR NO SE USA NI VOID NI RETURN (ES ESPECIAL */
        {
            ruedas = 4;
            largo = 230.5;
            ancho = 0.800;
            tapiceria = "tela";   /* tapiceria por defecto */


        }
        public Coche(double largo, double ancho)  /* Haciendo otro constructor donde le pueda pasar
                                                             *  parametros para hacer diferentes autos
                                                             *  SOBRECARGA DE CONSTRUCTORES */
        {
            ruedas = 4;
            this.largo = largo;
            this.ancho = ancho;
            tapiceria = "tela";  /* tapiceria por defecto */
        }
    }   
    partial class Coche
    { 
        private int ruedas = 4;    /* CAMPOS DE CLASE  */
        private double largo;
        private double ancho;
        private bool climatizador;  /*La declaro asi porque solo hay 2 opciones
                                     * coches que lo tengan = true
                                     * coches que no lo tengan = false */
        // el valor por defecto de las variables tipo "bool" es FALSE
                                    
        private string tapiceria;

        public string getInfoCoche()  /* Metodo getter para que me devuelve informacion sobre atributos de un objeto
                                       * se hace asi para que no pueda modificar sus atributos desde afuera, y asi los
                                       * declaro private 
                                       *  ESTO ES UN METODO*** */
        {
            return "Informacion del coche:\n" + "Ruedas: " + ruedas + " " + "Largo: " + largo + " " + "Ancho: " + ancho;
        }
        public void setExtras(bool climatizador,string tapiceria) /* Metodo setter para poder
                                                                             * setear parametros dentro de la clase como
                                                                             * climatizador si tiene o no tiene
                                                                             * y el tipo de tapiceria */
        {
            this.climatizador = climatizador;   /* USO DEL METODO "THIS" es para diferenciar  los campos de clase
                                                 * de los parametros de los metodos, y asi poder llamarlos igual */
            this.tapiceria = tapiceria;

        }
        public string getExtras()
        {
            return "Extras del coche:\n" + "Climatizador: " + climatizador + " " + "Tapiceria: " + tapiceria;

        }
    } 
}

