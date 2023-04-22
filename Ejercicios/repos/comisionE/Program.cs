namespace ComisionE
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = 0; 

            tomarNumero(numero);
            Console.WriteLine(numero);

            Persona juan = new Persona("Juan");

            tomarPersona(juan);
            Console.WriteLine(juan.name);  
        }
        static void tomarPersona(Persona persona) 
        {
            persona.name = "Como era?";//Asignando un valor de string a variable 
            
        }
        static void tomarNumero(int numero)
        {
            numero = 1;
        }
    }
     class Persona
    {   //prop name 
        public string name;//atributos : Caracteristicas del objeto
        public Persona(string name) //metodos: acciones que va a realizar
        { 
            this.name = name;//Campo , atributo de la clase Persona
        }



        static void inferenciadeTipos(int numero)// INFERENCIA DE TIPOS
        {
            int numeros = 5;
            float flotante = 3.14f;
            bool bandera = true;
            string texto = "Cadena de textos";

            //DIFERENTES TIPOS DE DATOS
            Console.WriteLine();
            //SI Utilizo VAR para no especificar que tipo de dato es pero una vez asignado
            //el valor no cambia el tipo.NO SE PUEDE MUTAR.
            var txt = "es tipo string";
            var num = 1;
            var floatt = 3.14f; //Usar poco y nada 


            //TODOO ES UN OBJETO ENTONCES PODEMOS DECLARAR UNA VARIABLE CON OBJETO
            object o = "objeto";//NO LO VAMOS A USAR

            dynamic dinamico = 1;//NO LO VAMOS A USAR

            //MODIFICAR LA CONSOLA
            //podemos pasarle variables
            Console.WriteLine("flotante{0}, bandera{1}",flotante, bandera);//los numero segun la posicion de las variables (MOSTRAMOS EL CONTENIDO)mascaras.



        }
    }

}