namespace Ejercicio_I02___Vos_cuántas_primaveras_tenés
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Persona personaUno = new Persona("Juan",4004523,1999,12,05);
            Persona personaDos = new Persona("Ramiro",38523652,2000,05,18);
            Persona personaTres = new Persona("Veronica",41252659,1989,06,27);

            Console.WriteLine(personaUno.Mostrar());
            Console.WriteLine(personaDos.Mostrar());
            Console.WriteLine(personaTres.Mostrar());


            Console.WriteLine(personaUno.EsMayorDeEdad());
            Console.WriteLine(personaDos.EsMayorDeEdad());
            Console.WriteLine(personaTres.EsMayorDeEdad());

            Console.WriteLine(personaUno.Mostrar());
            Console.WriteLine(personaDos.Mostrar());
            Console.WriteLine(personaTres.Mostrar());

        }
    }
}