using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] edades;       /* Creando un array */
            edades = new int[4];  /* Inicializando un array */
            edades[0] = 15;
            edades[1] = 27;
            edades[2] = 19;
            edades[3] = 80;
            Console.WriteLine(edades);
            // int[] edades = { 15, 27, 19, 80 };    (OTRA FORMA DE HACER TODO JUNTOS)

            // ARRAY IMPLICITOS
            var datos = new[] { "Juan", "Diaz", "Argentina" };
            var valores = new[] { 15, 25, 35, 75.5, 30.30,90,85.2 };  /* Si le paso diferentes datos numeros
                                                               * c# va a transformarme todos los datos a "double
                                                               * en cambio si tengo numericos y string, c# da error*/

            // ARRAY DE OBJETOS

            Empleados Ana = new Empleados("Ana", 27);

            Empleados[] arrayEmpleados = new Empleados[3];

            arrayEmpleados[0] = new Empleados("Sara", 37);

            arrayEmpleados[1] = Ana;

            arrayEmpleados[2] = new Empleados("Manuel", 51);

            // ARRAY DE TIPOS O CLASES ANONIMAS
            var personas = new[]
            {
                new{nombre="Juan",edad=19},
                new{nombre="Maria",edad=25},
                new{nombre="Diana",edad=30},

            };
            Console.WriteLine(personas[1]);   /* Imprimendo la posicion 1 del array personas */

            for (int i = 0; i < valores.Length ; i++)        /* Imprimiendo los valores del array "valores" */
            {
                Console.WriteLine(valores[i]);

            }
            
            int contador = 0;
            for (int i = 15; i >=11; i--)        /* Es otra forma de usar el for, pero moviendonos por el indice
                                                  * con  una variable aparte y sumandole 1 */
            {
                Console.WriteLine(valores[contador]);
                contador++;

            }
            for (int i = 0; i < arrayEmpleados.Length; i++)      /* Usamos el metodo getInfo (METODO GETTER) para poder
                                                                  * acceder a los atributos de los objetos que son privados */
            {
                Console.WriteLine(arrayEmpleados[i].getInfo());

            }
            
            
            foreach(Empleados variable in arrayEmpleados)    /* USANDO FOR EACH , sirve para recorrer un array
                                                              * y mostrar sus valores, pero no podemos modificarlos */
            {
                
                Console.WriteLine(variable.getInfo());     /* lo primero es inventar una variable del tipo de dato 
                                                            * del array a recorrer y luego el nombre del array */
            }
            foreach(double variable in valores)
            {
                Console.WriteLine(variable);
            }
            foreach(var variable in personas)
            {
                Console.WriteLine(variable);
            }
            
            
            
            
            int[] numeros = new int[4];    /* USANDO ARRAYS EN METODOS  */
            numeros[0] = 7;
            numeros[1] = 9;
            numeros[2] = 15;
            numeros[3] = 3;
            ProcesaDatos(numeros);
            
            int[] arrayElementos = LeerDatos();      //Guardo el array que devuelve el metodo en un array en el main 
            Console.WriteLine("Impriendo array desde el main");
            foreach(int i in arrayElementos)         // Imprimo el array
            {
                Console.WriteLine(arrayElementos[i]);

            }   


        }
        static void ProcesaDatos(int [] datos)    /* METODO PARA ARRAYS */
        {
            foreach(int i in datos)
            {
                Console.WriteLine(i);
            }
            for (int i = 0 ; i < 4 ; i++)          /* EDITANDO ARRAYS EN METODOS */
            {
                datos[i] += 10;

                Console.WriteLine(datos[i]);
            }
        }
        
        
        static int[] LeerDatos()       /*CREANDO ARRAYS DESDE UN METODO Y DEVOLVIENDOLO AL MAIN */
        {
            Console.WriteLine("Cuantos datos queres que tenga el array?");
            string respuesta = Console.ReadLine();
            int cantElementos = int.Parse(respuesta);   //Conviertiendo la respuesta en int 
            int[] datos = new int[cantElementos];       /* creando el array datos donde voy a guardar
                                                         * la cantidad de datos que me paso el usuarios(cantElementos)*/
            for(int i = 0; i < cantElementos; i++)
            {
                Console.WriteLine($"Introduce el dato para la posicion: {i}");
                respuesta = Console.ReadLine();
                int datosElemento = int.Parse(respuesta);
                datos[i] = datosElemento;              // LLenando el array
            }
            return datos;                              // Devuelvo el array al main
        }


    
    }
    class Empleados   /* Aca usamos los array de objetos */
    {
        public Empleados(String nombre, int edad)
        {
            this.nombre = nombre;
            this.edad = edad;
        }
        public string getInfo()
        {
            return "Nombre del empleado: " + " " + nombre + " "  + "edad: " +  edad;
        }
        string nombre;
        int edad;
    }


     // throw new ArgumentOutOfRangeException();   /* Invocando una exepcion*/
}
