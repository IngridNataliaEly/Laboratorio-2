using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_A02___La_veterinaria
{
    internal class Cliente
    {
        private string domicilio;
        private string nombre;
        private string apellido;
        private long telefono;
        private Mascota[] mascotas;

        public Cliente(string domicilio, string nombre, string apellido, long telefono, Mascota[] mascotas)
        {
            this.domicilio = domicilio;
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.mascotas = mascotas;
        }
        public void SetDomicilio(string domicilio)
        {
            this.domicilio = domicilio;
        }
        public string GetDomicilio()
        {
            return domicilio;
        }
        public void Setnombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string Getnombre()
        {
            return nombre;
        }
        public void SetApellido(string apellido)
        {
            this.apellido = apellido;
        }
        public string GetApellido()
        {
            return apellido;
        }
        public void Settelefono(long telefono)
        {
            this.telefono = telefono;
        }
        public long Gettelefono()
        {
            return telefono;
        }
        public void SetMascota(Mascota[] mascotas)
        {
            this.mascotas = mascotas;
        }
        public Mascota[] GetMascota()
        {
            return mascotas;
        }

    }
}
