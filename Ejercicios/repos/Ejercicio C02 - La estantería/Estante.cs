using System.Text;

namespace Ejercicio_C02___La_estantería
{
    internal class Estante
    {
        private Producto[] productos;
        private int ubicacionEstante;

        private Estante(int capacidad)
        {
            productos = new Producto[capacidad];//instanziar del array
        }
        public Estante(int capacidad, int ubicacion) : this(capacidad)
        {
            this.ubicacionEstante = ubicacion;
        }
        public Producto[] GetProductos()
        {
            return productos;
        }
        public static bool operator ==(Estante e, Producto p)
        {

            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i] == p)
                {
                    return true;
                }

            }
            return false;
        }
        public static bool operator !=(Estante e, Producto p)
        {
            return !(e == p);
        }
        public static bool operator +(Estante e, Producto p)
        {
            if (e != p)//si el producto no esta en el estante 
            {
                for (int i = 0; i < e.productos.Length; i++)
                {
                    if (e.productos[i] is null)//busco el lugar libre
                    {
                        e.productos[i] = p;
                        return true;
                    }
                }
            }
            return false;
        }
        public static Estante operator -(Estante e, Producto p)
        {

            for (int i = 0; i < e.productos.Length; i++)
            {
                if (e.productos[i] == p)//retornamos el estante sin el producto
                {
                    e.productos[i] = null;
                    break;

                }
            }
            return e;

        }
        public static string MostrarEstante(Estante e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine($"Ubicacion {e.ubicacionEstante}");
            for (int i = 0; i < e.productos.Length; i++)
            {
                if (!(e.productos[i] is null))
                {
                    sb.AppendLine(Producto.MostrarProducto(e.productos[i]));
                }
            }
            return sb.ToString();


        }








    }
}
