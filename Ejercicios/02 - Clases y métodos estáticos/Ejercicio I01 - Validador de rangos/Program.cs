namespace Ejercicio_I01___Validador_de_rangos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int acumulador = 0;
            int numero;
            int minimo = 0;
            int maximo = 0;

            Console.WriteLine("Ingrese 10 numeros");

            for (int i = 0; i < 10; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out numero))
                {
                    Console.WriteLine("Reingrese un numero");
                }
                if (Validador.Validar(numero, -100, 100))
                {
                    if (i != 0)
                    {
                        minimo = NumeroMinimo(minimo, numero);
                        maximo = NumeroMaximo(maximo, numero);
                    }
                    else
                    {
                        minimo = numero;
                        maximo = numero;
                    }
                }
                else
                {
                    Console.WriteLine("Error reingrese el numero ");
                    numero = int.Parse(Console.ReadLine());
                }
                acumulador += numero;
            }
            float prom = Promedio(acumulador, 10);

            Console.WriteLine("El promedio es{0}, el numero minimo {1},el numero maximo {2}", prom, minimo, maximo);

        }
        static public float Promedio(int acumulador, int cant)
        {
            return (float)acumulador / cant;
        }
        static public int NumeroMinimo(int valor, int ingresado)
        {
            if (ingresado <= valor)
            {
                valor = ingresado;
            }
            return valor;
        }
        static public int NumeroMaximo(int valor, int ingresado)
        {
            
            if (ingresado >= valor)
            {
                valor = ingresado;
            }
            return valor;
        }
    }
}