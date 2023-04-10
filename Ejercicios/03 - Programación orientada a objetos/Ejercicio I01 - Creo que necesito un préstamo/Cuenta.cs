using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I01___Creo_que_necesito_un_préstamo
{
    internal class Cuenta
    {
        private string titular;
        private double cantidad;
        public Cuenta(string titular, double cantidad)
        {
            this.titular = titular;
            this.cantidad = cantidad;
        }
        public string GetTitular()
        {
            return titular;
        }
        public double GetCantidad()
        {
            return cantidad;
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("==================");
            sb.AppendLine($"Titular: {titular}");
            sb.AppendLine($"cantidad: {cantidad}");
            sb.AppendLine("==================");

            return sb.ToString();
        }
        public bool Ingresar(double cantidad)
        {
            if(cantidad > 0 )
            {
                this.cantidad += cantidad;
                return true;
            }
            return false;
        }
        public double Retirar(double cantidad)
        {
            return this.cantidad -= cantidad;  
        }


    }
    
}
