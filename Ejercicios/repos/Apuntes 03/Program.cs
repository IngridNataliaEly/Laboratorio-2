namespace Apuntes_03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Objeto.tipo persona / instacnciar un objeto(guardandolo en memoria
            //Persona personaUno = new Persona("Miguel", "Rodriguez", 1234);//Constructor
            //Persona personaDos = new Persona("Facundo", "Gomez", 234);

            Persona personaUno = new Persona("Juan","Perez",123000);

            Persona personaDos = new Persona(123250);
            //personaUno.apellido = "Rodriguez";
            //personaUno.nombre = "Miguel";
            //personaUno.SetLegajo(123);
            //personaUno.legajo = 1234; 


            //personaDos.apellido = "Gomez";
            //personaDos.nombre = "Facundo";
            //personaDos.SetLegajo(234);
            //personaDos.legajo = 253;

            //Console.WriteLine(personaUno.Equals(personaDos));
            Console.WriteLine(personaUno);
            Console.WriteLine(personaDos);

        }
    }
}