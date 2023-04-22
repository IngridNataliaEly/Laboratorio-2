namespace Presenetacion
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Nuemero tipo de valor (estructura)
            int numero;
            CambiarValor(out numero);//llamo a metodo 
            Console.WriteLine(numero); //me muestra 12    
        }
        static void CambiarValor(out int numero)// OUT va a hacer que se refleje en la variable en el llamado.
                                                //OUT: le paso una variable que no tine valor y espero que el metodo me 
                                                //genere un valor en esa variable.
        {                                       // REF hace que el tipo de VALOR se comporte como tipo de referencia.
            //agarro el numero que recibo por parametro y 
            numero = 5 * 5;
        }
    }
}
