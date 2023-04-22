using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_A02___La_veterinaria
{
    internal class Mascota
    {
        private string especie;
        private string nombreMascota;
        private DateTime fechaNacimiento;
        public string[] vacunas;

        public Mascota(string especie, string nombreMascota, DateTime fechaNacimiento, string[] vacunas)
        {
            this.especie = especie;
            this.nombreMascota = nombreMascota;
            this.fechaNacimiento = fechaNacimiento;
            this.vacunas = vacunas;
        }

        public void SetfechaNacimiento(int anio, int mes, int dia)
        {
            fechaNacimiento = new DateTime(anio, mes, dia);
        }

        public DateTime GetfechaNacimiento()
        {
            return fechaNacimiento;
        }
        public void SetnombreMasc(string nombreMascota)
        {
            this.nombreMascota = nombreMascota;
        }
        public string GetnombreMasc()
        {
            return nombreMascota;
        }

        public void SetEspecie(string especie)
        {
            this.especie = especie;
        }
        public string GetEspecie()
        {
            return especie;
        }

        public string MostrarMascota()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine($"Nombre Mascota: {nombreMascota}");
            sb.AppendLine($"Especie: {especie}");
            sb.AppendLine($"Fecha Nacimiento: {fechaNacimiento}");
            if(EstadoVacunacion()==true)
            {
                foreach (var item in vacunas)
                {
                    sb.AppendLine($"Vacunas: {vacunas}");
                }
            }
            
            
            
            return sb.ToString();
        }
        public static bool EstadoVacunacion(string[] vacunas)
        {

            if(!(vacunas is null))
            {
                return true;
            }
            return false;
        }



    }
}
