namespace Ejercicio_I04___La_calculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char operador;
            int numeroUno = 0;
            int numeroDos = 0;
            Console.WriteLine("Ingrese +. Sumar -. Resta *. multiplicacion /. division");
            operador = Char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el operador uno (Dividendo,Multiplicando)");

            PedirNumero(out numeroUno);
            Console.WriteLine("Ingrese el operador Dos (Divisor,Multiplicador)");
            PedirNumero(out numeroDos);

            int resultado = Calculadora.Calcular(numeroUno, numeroDos, operador);
            Console.WriteLine(resultado);


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