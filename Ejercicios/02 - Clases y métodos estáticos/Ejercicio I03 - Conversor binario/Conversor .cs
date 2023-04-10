using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I03___Conversor_binario
{
    internal class Conversor
    {
        public static string ConvertirDecimalABinario(int numeroEntero) 
        {
            string binario = "";
            const int DIVISOR = 2;
            while (numeroEntero > 0)
            {
                binario += numeroEntero % DIVISOR ;
                numeroEntero = numeroEntero / DIVISOR;

            }
            return binario;
        }
        public static int ConvertirBinarioADecimal(int numeroEntero) 
        {
            int numero = 0;
            int digito = 0;
            const int DIVISOR = 10;
            for (int i = numeroEntero, j = 0; i > 0; i /= DIVISOR, j++)
            {
                digito = i % DIVISOR;
                if(digito != 1 && digito != 0)
                {
                    return -1;
                }
                numero += digito * (int)Math.Pow(2, j);
            }
                
                return numero;

        }

    }
}
