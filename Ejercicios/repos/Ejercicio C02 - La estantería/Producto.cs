namespace Ejercicio_C02___La_estantería
{
    internal class Producto
    {
        private string codigoDeBarra;
        private string marca;
        private float precio;


        public Producto(string codigoDeBarra, string marca, float precio)
        {
            this.codigoDeBarra = codigoDeBarra;
            this.marca = marca;
            this.precio = precio;
        }
        public string GetMarca()
        {
            return marca;
        }
        public float GetPrecio()
        {
            return precio;
        }

        public static string MostrarProducto(Producto p)
        {
            return $"codigoDeBarra : {p.codigoDeBarra} marca: {p.marca}" +
                $" precio : {string.Format("{0:N2}", p.precio)}"; //mostrar dos decimales   
        }
        public static explicit operator string(Producto p)
        {
            return p.codigoDeBarra;
        }
        public static bool operator ==(Producto p1, Producto p2)
        {
            if (!(p1 is null || p2 is null))
            {
                return p1.marca == p2.marca && p1.codigoDeBarra == p2.codigoDeBarra;
            }
            return false;
        }
        public static bool operator !=(Producto p1, Producto p2)//hay que sobrecargar su contraparte
        {
            return !(p1 == p2);//reutilizo la marca anterior
        }
        public static bool operator ==(Producto p, string marca)
        {
            if (p.marca == marca)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public static bool operator !=(Producto p, string marca)//hay que sobrecargar su contraparte
        {
            return !(p == marca);
        }









    }
}
