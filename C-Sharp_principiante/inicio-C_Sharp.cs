using System;
using System.Reflection.Emit;


namespace CSharpHelloWorld
{
    class Hello_World
    {
        static void Main(string[] args)
        {
            // comentarios 
            Console.WriteLine("Hello, C#, the brother of Java!"); 

            //var
            string myString = "Per la mia mamma";
            myString = "Ahora hemos cambiado el valor";
            Console.WriteLine(myString);

            int edad = 7;
            int edadHermano;
            edadHermano = edad + 3;

            Console.WriteLine(edadHermano);

            double myDble= 6.5;
            float myFlt= 5.5f;

            //se pueden sumar entre ellos
            Console.WriteLine(myDble+myFlt+edad);

            Console.WriteLine($"edad es = {edad} ");

            //var myVar= "El tipo de var lo coge automatico";
            //const string MyConst = "1º las const son UCC, 2ª NO pueden con tipo inferido como las var";
            //ms
            //Estructuras 

            var myArray = new string[]{"Jonatan", "Sandra", "Liam", "Unai"};
            Console.WriteLine(myArray);
            Console.WriteLine(myArray[3]);


            //Par clave:valor
            var myDictionary = new Dictionary<string,int>
            {
                {"Jonatan", 38},
                {"Sandra", 35},
                {"Liam", 5},
                {"Unai", 0}

            };

            //SET es un ArrayList, que no admite repetidos
            var mySet = new HashSet<string>{"Jonatan", "Liam", "Jonatan", "Liam"};
                //solo tendra 2 de long

               


            // Bucles

                    Console.WriteLine("PROCEDEMOS A LEER EL ARRAY");            
            for (int i = 0; i <myArray.Length; i++)
                {
                    Console.WriteLine(myArray[i]);            
                }

                    Console.WriteLine("PROCEDEMOS A LEER EL DICCIONARIO con foreach");            
            foreach (var item in myDictionary)
            {
                Console.WriteLine(item);   
            }

            //Flujos
            int prueba = 25;
            if (prueba == 25)
            {
                Console.WriteLine("El valor es 25");
            }
            else
            {
                Console.WriteLine("Como no es 25, sacamos el ELSE");
            }

            metodo(22,33);


            //instancia a la clase
            var miPerro = new Perro("Negro", "ChowChow");
            Console.WriteLine($"La raza de miPerro es {miPerro.raza}, y su color es {miPerro.color}") ;

            

        }


        static void metodo(int numA, int numB)
        {
            int resultado = numA + numB;
            Console.WriteLine("Funcion simple, el resultado de sumar parametros es: "+ resultado) ;
        }

        class Perro
        {
            public string color {get; set;}
            public string raza {get; set;}


            //constructor
           
            public Perro(string myColor, string myRaza){
                color = myColor;
                raza = myRaza;
            }
        }

    }

    
    
}

