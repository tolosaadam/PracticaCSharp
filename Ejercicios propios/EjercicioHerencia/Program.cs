using System;

namespace EjercicioHerencia
{
    
    
    class Program
    {
        static void Main(string[] args)
        {
            Vehiculo coche1 = new Coche("Fiat600","coche", 80, 200);
            coche1.conducir();
            Vehiculo avion1 = new Avion("Avionaso","avion", 500, 100);
            avion1.conducir();
            Vehiculo moto1 = new Moto("Motito", "moto", 40, 100);
            moto1.conducir();
            coche1.arrancarMotor();           // Arranco el motor de coche
            coche1.getInfoVehiculo();    
            coche1.pararMotor();              // Paro el motor de coche
            coche1.getInfoVehiculo();

            // ARRAYS
            Vehiculo[] arraysVehiculo = new Vehiculo[3];
            arraysVehiculo[0] = coche1;
            arraysVehiculo[1] = avion1;
            arraysVehiculo[2] = moto1;  /* Me muestra en pantalla el metodo de la clase madre porque no defini
                                         * un metodo dentro de la clase motito */

            avion1.arrancarMotor();  // APAGO LOS MOTORES DE AVION Y MOTO
            moto1.arrancarMotor();

            Console.WriteLine("**IMPRIENDO DESDE LA LISTA CON UN FOR** ");
            for (int i=0; i < arraysVehiculo.Length; i++)  /* IMPRIMIENDO TODOS LOS OBJETOS DE LA LISTA "ARRAYVEHICULOS" con sus 
                                                            * respectivos metodos polimorficos */
                
            {
                arraysVehiculo[i].conducir();
                arraysVehiculo[i].getInfoVehiculo();
                
            }

        }
    }
    class Vehiculo
    {
        // Campos de clase
        protected string nombre { get; set; }    // LOS DEFINO COMO PROTECTED PARA PODER USARLOS DESDE LA MISMA CLASE 
        protected string tipo { get; set; }
        protected int ancho { get; set; }
        protected int largo { get; set; }
        protected string motor { get; set; } = "apagado";   /* Pongo por defecto que todos los motores esten apagados, a menos que use el metodo
                                              * "APAGAR O PRENDER MOTOR" */
        public Vehiculo(string nombre,string tipo, int ancho, int largo)
        {
            this.nombre = nombre;
            this.tipo = tipo;
            this.ancho = ancho;
            this.largo = largo;
            
           

            
        }

        public void arrancarMotor()
        {
            motor = "encendido";
        }
        public void pararMotor()
        {
            motor = "apagado";
        }
        public virtual void conducir()
        {
            Console.WriteLine($"Estoy conduciendo un {nombre}");
        }
        public void getInfoVehiculo()
        {
            Console.WriteLine($"El vehiculo de tipo {tipo} tiene un ancho de {ancho}, un largo de {largo}, con el motor: {motor}");
        }
        

    }
    class Avion : Vehiculo
    {
        public Avion(string nombre,string tipo, int ancho, int largo):base(nombre,tipo, ancho, largo)
        {
            
        }

        public override void conducir()
        {
            Console.WriteLine($"Estoy conduciendo el avion {nombre}");
        }

    }
    class Coche : Vehiculo
    {
        public Coche(string nombre,string tipo,  int ancho, int largo) : base(nombre,tipo, ancho, largo)
        {

        }

        public override void conducir()
        {
            Console.WriteLine($"Estoy conduciendo el coche {nombre}");
        }
        
    }
    class Moto : Vehiculo
    {
        public Moto(string nombre, string tipo, int ancho, int largo) : base(nombre, tipo, ancho, largo)
        {

        }
    
    }
}
