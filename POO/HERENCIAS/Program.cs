using System;

namespace HERENCIAS
{
    class Program                                                   /* EL MOTIVO DE LA HERENCIA ES PARA PODER
                                                                     * RETUILIZAR CODIGO */
    {
        static void Main(string[] args)
        {
            Caballo caballo1 = new Caballo("Babieca");
            Caballo caballo2 = new Caballo("Babieca2");
            
            Humano humano1 = new Humano("Adam");
            
            Gorila gorila1 = new Gorila("Gorilin");

            Mamiferos animal1 = new Caballo("Bucefalo");   // PRINCIPIO DE SUSTITUCION
            /* Aunque estoy creando un objeto de tipo caballo, no puedo usar sos metodos, ya que en realidad
             * es un objeto de tipo Mamifero */
            Mamiferos animal2 = new Humano("Rodo");
            


            
            
            
            Mamiferos animal3 = new Mamiferos("asd123");   /* Estoy haciendo principio de sustitucion pero en 3 lineas 
                                                            * las puedo igualar ya que un "Caballo" siempre es un "Mamifero */
            Caballo animal4 = new Caballo("ASD123");
            animal3 = animal4;                          /* En una variable de tipo mamifero estoy almacenando una variable
                                                         * de tipo caballo */
            animal3.getNombre();


            
            
            
            // USANDO PRINCIPIO DE SUSTITUCION CON LA SUPER CLASE COSMICA "OBJECT"
            Object miCaballo = new Caballo("Caballito");
            Object miHumano = new Humano("Humanito");
            Object miGorila = new Gorila("Gorilita");



            // ARRAYS
            Caballo[] almacenDeCaballos = new Caballo[3];    /* Arrays de tipo Caballo, solo puedo guardar 
                                                              * objetos de tipo "Caballo", para guardar todos los tipos
                                                              * tengo que usar el principio de sustituticon
                                                              * y crear un array de tipos mamiferos */
            almacenDeCaballos[0] = caballo1;

            Mamiferos[] almacenDeMamiferos = new Mamiferos[3];   // Guardando un objeto de tipo humano en el array de mamiferos
            almacenDeMamiferos[0] = humano1;                      /* Como el array es de tipo Mamiferos, solo puedo usar
                                                                   * metodos de tipo mamifero y no de cada subclase */
            almacenDeMamiferos[1] = caballo1;
            almacenDeMamiferos[2] = gorila1;

            // USANDO ARRAY CON POLIMORFISMO
            Console.WriteLine("BUCLE FOR");
            for (int i = 0; i < almacenDeMamiferos.Length; i++)  /* EL METODO PENSAR SE ESTA COMPORTANDO SEGUN LO QUE INDIQUE
                                                                  * EN CADA METODO DE CADA SUBCLASE, SOLO EN LA CLASE "Gorila"
                                                                  * use el override, por eso en la clase "Humano" no se 
                                                                  * sobreescribe, y la clase "Caballo" ni si quiera 
                                                                  * use un metodo pensar, por eso hereda el de la clase "Mamifero"*/
            {
                almacenDeMamiferos[i].pensar();
            }







            humano1.getNombre();
            humano1.pensar();
            caballo1.getNombre();
            gorila1.getNombre();
            humano1.cuidarCrias();
            
            
            
            // POLIMORFISMO
            humano1.pensar();
            caballo1.pensar();


            //INTERFACES

            Console.WriteLine("USANDO INTERFAZES\n");
            Ballena ballena1 = new Ballena("ballenita1");
            IMamiferosTerrestres IMiCaballo1 = caballo1;      /*Aca le estamos diciendo que caballo1 "ES-UN" mamifero terrestre
                                                               * esto se usa para poder utilizar los metodos encapsulados de
                                                               * la interfaz */
            ballena1.nadar();
            Console.WriteLine("El numero de patas de caballo 1 es: " + IMiCaballo1.numeroPatas());

            IAnimalYSaltoConPatas Imicaballo1 = caballo1;
            IAnimalYSaltoConPatas Imicaballo2 = caballo2;
            Console.WriteLine("El numero de patas con el que salta el caballo 1 es: " + Imicaballo1.numeroPatas());
            Console.WriteLine("El numero de con el que salta el caballo2 es: " + Imicaballo2.numeroPatas()); //Usando la otra interfaz


            // CLASES ABSTRACTAS
            // LAS CLASES ABSTRACTAS SON SIMIALRES A LAS INTERFACES, PERO PUEDO DESARROLLAR SUS METODOS
            Console.WriteLine("USANDO CLASES ABSTRACTAS");
            
            Lagartija lagartija1 = new Lagartija("Juanchito");
            lagartija1.respirar();
            lagartija1.getNombre();
            Humano humano5 = new Humano("Javi enanioide");
            humano5.respirar();
            humano5.getNombre();
            humano5.pensar();



            

        }
    }
                                //INTERFAZ
                                /*  LA INTERFAZ SE DECLARA APARTE DE TODAS LAS CLASES Y SE TIENE QUE DECLARAR LOS METODOS
                                 *  EN CADA CLASE QUE LO VA A HEREDAR, ESTO SE USA POR SI TENES ALGUNA SUBCLASE QUE NO QUERES
                                 *  QUE HEREDE ALGUN METODO, el nombre del metodo debe coincidir con el que se definio en la interfaz
                                 *  tambien el tipo de dato y cantidad de argumentos
                                 *  OBLIGATORIEDAD: COMO PROGRAMADOR OBLIGO A QUE LAS CLASES TENGAN EL METODO QUE DEFINO
                                 *  EN LA INTERFAZ, ASI SI OTRO PROGRAMADOR VA A CREAR OTRA CLASE DEBE USAR EL METODO.
                                 *  
                                 *  EL SENTIDO DE LA INTERFAZ ES LOGRAR QUE EL METODO SE COMPORTE DE DIFERENTE MANERA
                                 *  DEPENDE EL METODO DONDE SE DESARROLLE.
                                 *  
                                 * RESTRICCIONES: - NO SE PERMITE DEFINIR VARIABLES -CONSTRUCTORES -DESTRUCTORES- 
                                 * -NO SE PUEDEN DEFINIR MODIFICADORES DE ACCESO (TODOS SON PUBLIC POR DEFECTO 
                                 * -No se puede definir una clase dentro de una interfaz */
                                 
interface IMamiferosTerrestres
{
        int numeroPatas();         // No se debe poner modificadores de acceso en los metodos de la interfaz

}

interface IAnimalesYDeportes
    {
        string tipoDeporte();     // El tipo de deporte
        bool esOlimpico();        // Si un animal practica o no deportes olimpicos
    
    }
interface IAnimalYSaltoConPatas
    {
        int numeroPatas();          //Las cantidad de patas con las que salta

    }
    
    
    abstract class Animales
    {
        public void respirar() 
        {
            Console.WriteLine("Soy capaz de respirar");
        }
        public abstract void getNombre(); /* Siempre que en una clase tenes un metodo abstracto obligas a la clase a ser abstracta
                                           * se declara como en las interfaces */
    }
    class Mamiferos : Animales
    {
        public Mamiferos(String nombre)       // Construtor de la clase madre
        {
            nombreSerVivo = nombre;


        }
        protected void respirarEjemplo()   /* CON "PROTECTED" solo sera accesible al metodo dentro de las clases Mamifero y sus herencias
                                     *(no puedo usarlo desde la clase principal "Program" por ejemplo */
        {
            Console.WriteLine($"Soy capaz de respirar soy {nombreSerVivo}");
        }
        
        public virtual void pensar() /* Empiezo con polimorfismo.
                                      * aca le estamos indicando a C# que con la palabra "VIRTUAL" que todas las subclases
                                      * de "Mamiferos" deben tener un metodo de "pensar" que modifiquen el metodo de pensar 
                                      * de la clase mamiferos */
        {
            Console.WriteLine("Pensamiento basico instintivo");
        }
        
        public void cuidarCrias()
        {
            Console.WriteLine($"Cuido de mis crias hasta que se valgan por si solas soy {nombreSerVivo}" );
        }
        
       
        public override void getNombre()     /* Metodo getter de string, las sub clases heredan los metodos
                                              * uso "override" para sobreescribir el metodo abstracto "getNombre()" */
        {
            Console.WriteLine($"El nombre del mamifero es: {nombreSerVivo}");
        }
        private String nombreSerVivo { get; set; }   // CAMPO DE CLASE ENCAPSULADA "private"
    }
    class Caballo : Mamiferos, IMamiferosTerrestres , IAnimalesYDeportes , IAnimalYSaltoConPatas    // PRIMERO VA NOMBRE DE CLASE Y LUEGO INTERFACES

    {
        
        public Caballo(String nombreCaballo):base(nombreCaballo)    // Constructor de las clase hijo ":base()"
        {

        }
        public void galopar()
        {
            Console.WriteLine("Soy capaz de galopar");
        }
        
        //Interfaz en caballo
        int IMamiferosTerrestres.numeroPatas()    /* Asi solucionamos el problema de ambiguedad cuando tengo
                                                   * 2 metodos con el mismo nombre proveniente de diferentes interfaces.
                                                   *  Usando (tipo de dato) NombreDeInterfaz.NombreDelMetodo */
        {
            return 4;
        }
        
        int IAnimalYSaltoConPatas.numeroPatas()
        {
            return 2;
        }
        public string tipoDeporte()
        {
            return "Carrera de caballos";
        }
        public Boolean esOlimpico()
        {
            return true;
        }
    }
    
    class Humano : Mamiferos , IMamiferosTerrestres , IAnimalesYDeportes
    {
        public Humano(String nombreHumano) : base(nombreHumano)   //Constructor de clase heredada
        {

        }
        public   void pensar()   /* Polimorfismo, al tener el mismo nombre de metodo, que el de mamifero,
                                * cuando uso el metodo con un humano, se reemplaza el metodo definido en mamiferos
                                * y se usa el metodo definido en humanos, (VER LINEA 71) */
        {
            Console.WriteLine("Pensamiento de humano");
        }
        
        //Interfaz de huamano
        public int numeroPatas()
        {
            return 2;
        }
        public string tipoDeporte()
        {
            
            return "Salto con garrocha";
        
        }
        public Boolean esOlimpico()
        {
            return true;
        }
    }

    class Gorila : Mamiferos , IMamiferosTerrestres
    {
        public Gorila(String nombreGorila) : base(nombreGorila)
        {

        }
        public override  void pensar() /* Polimorfismo con la palabra "OVERRIDE" le indico a C# que el metodo "pensar" de la
                                        * clase gorila MODIFICA el metodo pensar de la clase "Mamiferos" Sino solo lo trata como
                                        * un metodo diferente (Como en la clase humano)*/
        {
            Console.WriteLine("Pensamiento de gorila");
        }
        public void trepar()
        {
            Console.WriteLine("Soy capaz de trepar");
        }
        public int numeroPatas()
        {
            return 2;
        }
        
        
    }

    //INTERFACES
    class Ballena : Mamiferos
    {
        public Ballena (String nombreBallena) : base(nombreBallena)
        {

        }

        public void nadar()
        {
            Console.WriteLine("Soy una ballenita y estoy nadando");
        }
    }
    
    class Lagartija : Animales
    {
        public Lagartija(String nombre)
        {
            nombreReptil = nombre;
        }
        public override void getNombre()     
                                              
        {
            Console.WriteLine($"El nombre de la lagartija  es: {nombreReptil}");
        }
        private String nombreReptil;
    }
}
