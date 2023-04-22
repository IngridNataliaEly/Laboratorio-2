namespace Ejercico_2
{
    /*
     * Ingresar un número y mostrar el cuadrado y el cubo del mismo.
     * Se debe validar que el número sea mayor que cero, caso contrario,
     * mostrar el mensaje: "ERROR. ¡Reingresar número!".*/
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero!");
            double numero = Convert.ToDouble(Console.ReadLine());
            double resCuadrado, resCubo;
            while (numero <= 0)
            {
                Console.WriteLine("ERROR. ¡Reingresar número!");
                 numero = Convert.ToDouble(Console.ReadLine());
            }
            resCuadrado = Math.Pow(numero, 2);
            resCubo = Math.Pow(numero, 3);   
            Console.WriteLine("Numero {0} Elevado al Cuadrado = {1} y elevado al Cubo = {2}",numero, resCuadrado,resCubo);
        }
    }
}