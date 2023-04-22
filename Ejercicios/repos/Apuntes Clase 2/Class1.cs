using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apuntes_Clase_2
{
    internal class Math
    {
        static public int ElevaralCuadrado(int resultado)
        {
            return resultado * resultado;
        }
        /// <summary>
        /// Suma dos numeros y devulve el resultado
        /// </summary>
        /// <param name="numeroUno"></param>
        /// <param name="numeroDos"></param>
        /// <returns>la suma</returns>
        static public int Sumar(int numeroUno,int numeroDos)
        {
            //TODO refactorizar
            return numeroUno + numeroDos;
        }
        static public int Restar(int numeroUno, int numeroDos)
        {
            return numeroUno - numeroDos;
        }

    }
}
