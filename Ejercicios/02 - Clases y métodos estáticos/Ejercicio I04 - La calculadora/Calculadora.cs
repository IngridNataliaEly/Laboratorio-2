namespace Ejercicio_I04___La_calculadora
{
    internal class Calculadora
    {
        public static int Calcular(int numeroUno, int numeroDos, char operador)
        {
            int resultado = 0;
            switch (operador)
            {
                case '+':
                    resultado = numeroUno + numeroDos;
                    break;
                case '-':
                    resultado = numeroUno - numeroDos;
                    break;
                case '*':
                    resultado = numeroUno * numeroDos;
                    break;

                case '/':
                    if(Validar(numeroDos))
                    {
                        resultado = numeroUno / numeroDos;
                        
                    }
                    else
                    {
                        Console.WriteLine("Error");
                    }
                    break;


            }
            return resultado;
        }
        private static bool Validar(int numeroDos)
        {
            if(numeroDos != 0)
            {
                return true;
            }
            return false;
        }
    }
}
