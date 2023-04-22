using System;
namespace Ejercicio_I03___El_ejemplo_universal
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Estudiante primerEstudiante = new Estudiante("Ramirez", "2354", "Gabriel");
            Estudiante SegundoEstudiante = new Estudiante("Ely", "3654", "Juan");
            Estudiante TercerEstudiante = new Estudiante("Lipe", "6356", "Lorena");


            
            primerEstudiante.SetNotaPrimerParcial(4);
            primerEstudiante.SetNotaSegundoParcial(9);

            SegundoEstudiante.SetNotaPrimerParcial(10);
            SegundoEstudiante.SetNotaSegundoParcial(10);

            TercerEstudiante.SetNotaPrimerParcial(2);
            TercerEstudiante.SetNotaSegundoParcial(2);

            Console.WriteLine(primerEstudiante.Mostrar());
            Console.WriteLine(SegundoEstudiante.Mostrar());
            Console.WriteLine(TercerEstudiante.Mostrar());




        }
    }
}