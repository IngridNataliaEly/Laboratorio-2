namespace Ejercicio_I03___Conversor_binario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int opciones;
            int numero = 0;
            string respuesta;
            int respuestaD;
            Console.WriteLine("Ingrese un 1. para decimal o 2. Binario ");
            PedirNumero(out opciones);

            switch (opciones)
            {
                case 1:
                    PedirNumero(out numero);
                    respuesta = Conversor.ConvertirDecimalABinario(numero);
                    Console.WriteLine("El numero {0} en binario es {1}", numero, respuesta);
                    break;

                case 2:
                    PedirNumero(out numero);
                    respuestaD = Conversor.ConvertirBinarioADecimal(numero);
                    if (respuestaD != -1)
                    {
                        Console.WriteLine("El numero binario {0} en decimal es {1}", numero, respuestaD);
                    }
                    else
                    {
                        Console.WriteLine("Error no es numero binario");
                    }
                    break;

                default:
                    Console.WriteLine("Opcion Invalida");
                    break;
            }

            static bool PedirNumero(out int numero)
            {
                Console.WriteLine("Ingrese un numero");
                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("REIngrese un numero Valido");
                }
                return true;
            }
        }
    }
}