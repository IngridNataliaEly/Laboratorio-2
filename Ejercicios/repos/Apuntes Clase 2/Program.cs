using M = System.Math;// alias de clase


namespace Apuntes_Clase_2
{
    public class Program
    {
        public static void Main(string[] args)
        {
           
            Console.WriteLine("Ingrese un numero");

            bool rtaParse = int.TryParse(Console.ReadLine(), out int resultado);

            int cuadrado = Math.ElevaralCuadrado(resultado);
            
            if(rtaParse)
            {
                Console.WriteLine("S pudo");
            }
            else
            {
                Console.WriteLine("No se puede");
            }
            Console.WriteLine(cuadrado);

        }

    }
}