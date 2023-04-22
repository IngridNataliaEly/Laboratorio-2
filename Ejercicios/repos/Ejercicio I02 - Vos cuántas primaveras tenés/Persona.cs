using System.Text;

namespace Ejercicio_I02___Vos_cuántas_primaveras_tenés
{
    internal class Persona
    {
        private string nombre;
        private DateTime fechaNacimiento;
        private int dni;
        public Persona(string nombre, int dni, int anio, int mes, int dia)
        {

            Setnombre(nombre);
            SetfechaNacimiento(anio, mes, dia);
            Setdni(dni);
        }
        public void SetfechaNacimiento(int anio, int mes, int dia)
        {
            fechaNacimiento = new DateTime(anio, mes, dia);
        }

        public DateTime GetfechaNacimiento()
        {
            return fechaNacimiento;
        }
        public void Setnombre(string nombre)
        {
            this.nombre = nombre;
        }
        public string Getnombre()
        {
            return nombre;
        }
        public void Setdni(int dni)
        {
            this.dni = dni;
        }
        public int Getdni()
        {
            return dni;
        }
        private double CalcularEdad()
        {
            DateTime fechaActual = DateTime.Now;
            TimeSpan diferencia = fechaActual - fechaNacimiento;
            double dias = diferencia.TotalDays;

            return Math.Floor(dias / 365);

        }
        public string Mostrar()
        {

            StringBuilder sb = new StringBuilder();
           
            sb.AppendLine($"Nombre: {nombre}");
            sb.AppendLine($"Fecha Nacimiento: {fechaNacimiento}");
            sb.AppendLine($"dni: {dni}");
            sb.AppendLine($"edad: {CalcularEdad()}");
            

            return sb.ToString();
        }
        public string EsMayorDeEdad ()
        {
            if (CalcularEdad() < 18)
            {
                return ("Es Menor de edad");
            }
            else
            {
                return ("Es Mayor de edad");
            }
        }
    }

}

