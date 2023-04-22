using System.Text;

namespace Ejercicio_I03___El_ejemplo_universal
{
    internal class Estudiante
    {
        private string apellido;
        private string legajo;
        private string nombre;
        private int notaPrimerParcial;
        private int notaSegundoParcial;
        private static Random random;

        static Estudiante()//No se llaman, se ejecuta solo 
        {
            random = new Random();//lo estactico no tiene acceso a la instansia
        }
        public Estudiante(string apellido, string legajo, string nombre)
        {
            this.apellido = apellido;
            this.legajo = legajo;
            this.nombre = nombre;
        }
        public void SetNotaPrimerParcial(int notaPrimerParcial)
        {
            this.notaPrimerParcial = notaPrimerParcial;
        }
        public void SetNotaSegundoParcial(int notaSegundoParcial)
        {
            this.notaSegundoParcial = notaSegundoParcial;
        }


        public double CalcularNotaFinal()
        {
            if (notaPrimerParcial >= 4 && notaSegundoParcial >= 4)
            {
                return (random.NextDouble() * 4 + 6);
            }
            else
            {
                return -1;
            }

        }
        private float CalcularPromedio()
        {
            return (notaPrimerParcial + notaPrimerParcial) / 2; 
        }
        public string Mostrar()
        {
            double nota = CalcularNotaFinal();
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("==================");
            sb.AppendLine($"Nombre : {nombre}");
            sb.AppendLine($"Apellido: {apellido}");
            sb.AppendLine($"Legajo: {legajo}");
            sb.AppendLine($"Nota primer parcial : {notaPrimerParcial: 0.0} ");
            sb.AppendLine($"Nota Segundo Parcial: {notaSegundoParcial: 0.0}");

            sb.AppendLine($"Promedio: {CalcularPromedio():0.0}");
            if (nota != -1)
            {
                sb.AppendLine($"Nota Final: {nota:0.0}");
            }
            else
            {
                sb.AppendLine("Alumno Desaprobado");
            }
            sb.AppendLine("==================");


            return sb.ToString();
        }
    }
}

