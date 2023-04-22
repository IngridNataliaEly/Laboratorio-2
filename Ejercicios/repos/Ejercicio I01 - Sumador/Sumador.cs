using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I01___Sumador
{
    internal class Sumador
    {
        private int cantidadSumas;
        public  Sumador(int cantidadSumas)//recibe entero 
        {
            this.cantidadSumas = cantidadSumas;
        }
        public Sumador() : this(0)//inicializa cantidadSumas en cero
        {
            
        }
        public int GatCantSumas()
        {
            return cantidadSumas;
        }

        public long Sumar(long a,long b)
        {
            this.cantidadSumas ++;
            return a + b;
        }
        public string Sumar(string a, string b)
        {
            this.cantidadSumas ++;
            return a + b;
        }
        public static explicit operator int(Sumador s)
        {
            return s.cantidadSumas;
        }
        public static long operator +(Sumador s1, Sumador s2)
        {
            return s1.cantidadSumas + s2.cantidadSumas;
        }
        public static bool operator|(Sumador s1, Sumador s2) 
        {
            if (s1.cantidadSumas == s2.cantidadSumas)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
       


    }
   

}
