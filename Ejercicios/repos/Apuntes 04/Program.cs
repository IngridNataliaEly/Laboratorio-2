using Apuntes_03;

namespace Apuntes_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //System.Console.WriteLine("Hello world");
            //CD acdc = new CD();

            //acdc.Titulo = "Back in black";
            //acdc.Anio = 1980;//Es una propiedad NO un metodo  esto es un seter. que se esta ejecutando en la lcase CD.DEJA DE SER UN ATRIBUTO
            //Console.WriteLine(acdc.Titulo);


            Persona personaUno = new Persona("Juan", "Perez", 123000);

            Persona personaDos = new Persona(123000);


         
            Console.WriteLine("========================");
            Console.WriteLine(personaUno.Promedio);
            
            Console.WriteLine("========================");
            personaUno++;

            Console.WriteLine(personaUno.Promedio);
            Console.WriteLine("========================");
            Console.WriteLine( personaUno + personaDos);
            Console.WriteLine(11 + personaUno);
            if (personaUno == personaDos)
            {
                Console.WriteLine("Son iguales");
            }
            else
            {
                Console.WriteLine("Son distintos");
            }

           
            Console.WriteLine(personaUno); 
            Console.WriteLine(personaDos);

        }
    }
}