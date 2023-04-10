namespace Ejercicio_I02___Desea_continuar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char respuesta;
            int acumulador = 0;
            int numero;
            do
            {
                Console.WriteLine("Ingrese Un nuemero");
                if (int.TryParse(Console.ReadLine(), out  numero))
                {
                    acumulador += numero;
                    Console.WriteLine("La suma es {0}",acumulador);
                }
                Console.WriteLine("Desea Continuar?");
                respuesta = char.Parse(Console.ReadLine());
            } while (Validador.ValidarRespuesta(respuesta));
        }
        
    }
}