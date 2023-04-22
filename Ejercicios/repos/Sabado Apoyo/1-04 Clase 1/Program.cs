using System.Text;

namespace _1_04_Clase_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero;
            PedirNumero(out numero);
            Console.WriteLine(numero);
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



