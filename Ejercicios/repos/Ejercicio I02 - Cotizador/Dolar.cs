namespace Billetes
{
    internal class Dolar
    {
        private double cantidad;
        private static double cotzRespectoDolar;


        static Dolar()
        {
            Dolar.cotzRespectoDolar = 1;
        }
        public Dolar(double cantidad) 
        {
            this.cantidad = cantidad;
        }
        public double getCantidad()
        {
            return cantidad;
        }
        public double getCotzRespectoDolar()
        {
            return cotzRespectoDolar;
        }
        public static  explicit operator Euro(Dolar d)
        {
            
        }

















    }
}
