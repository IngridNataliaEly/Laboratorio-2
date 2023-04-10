using System.Text;

namespace Ejercicio_3_Los_primos
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Ingrese un numero");
            //string numeroI = Console.ReadLine();
            int numeroI =int.Parse(Console.ReadLine());
            Console.WriteLine(listarNumeroPrimos(numeroI));

           // bool sePudo = int.TryParse(numeroI, out int resultado);//
        }
       /* public static bool esNumerico(string cadena)
        {
            return int.TryParse(cadena, out int resultado);
        }*/
        public static string  listarNumeroPrimos(int hasta)//string que ciontenga llos numeros primos 
        {
            StringBuilder sb = new StringBuilder();//armar strings largos,cocatenarlos
            for(int i = 2; i <= hasta; i++)
            {
                if(esPrimo(i))
                {
                    //sb.AppendFormat("{0} ,",i);
                    sb.Append($"{i},");//Instancia del string builder
                }
            }
            return sb.ToString();
        }
        public static bool esPrimo(int numeroTope)
        {
            for(int i = 2;i< numeroTope; i++) 
            {
                if(numeroTope % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}