namespace Ejercicio_I01___Sumador
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Sumador s1 = new Sumador(5);
            Sumador s2 = new Sumador(5);


            int cantidadSuma1 = (int)s1;

            Console.WriteLine(s1.Sumar(5, 5));

            Console.WriteLine($"Cant Sumas: {cantidadSuma1}");

            Console.WriteLine(s2.Sumar("Hola", "Mundo"));

            int cantidadSuma2 = (int)s2;

            Console.WriteLine($"Cant Sumas: {cantidadSuma2}");

            Console.WriteLine($"Sumas: {s1 + s2}");

            Console.WriteLine(s1 | s2);
        }
    }
}