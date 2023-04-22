using System.Text;

namespace Apuntes_03
{
    internal class Persona//Es la generalizacion (en singular y con mayuscula)
    {
        /****
         * OPERADORES : 
         * unarios : ++,--,!,-,+,*,true, false
         * 
         * binarios : 
         * otros  : ||
         * 
      
         * 
         */
        public string Nombre { get => _nombre; set => _nombre = value; }//prpiedad
        private string _nombre; //Atributo, la caracteristca o estado de un objeto


        public string Apellido { get => _apellido; set => _apellido = value; }
        private string _apellido;

        public int Promedio { get; set; } = 0;

        public int Legajo { get => _legajo; private init => _legajo = value > 100000 ? value : throw new InvalidOperationException(); }
        private int _legajo;
        //seter prvado solo quiero que se haga dentro de la clase

        //SOBRECARGA 
        public Persona(int legajo)
        {
            Legajo = legajo;
        }

        public Persona(string nombre, string apellido, int legajo)//Constructor
        {
            Nombre = nombre;
            Apellido = apellido;
            Legajo = legajo;

        }

        //public void SetLegajo(int legajo)
        //{
        //    this._legajo = legajo;//en this voy a tener toda la instancia
        //}                        //lo usamos cuadno exista ambiedad en variables
        //public int GetLegajo()
        //{
        //    //return this.legajo;
        //    return _legajo;
        //}
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("==================");
            sb.AppendLine($"Nombre: {_nombre}");
            sb.AppendLine($"Apellido: {_apellido}");
            sb.AppendLine($"Legajo: {_legajo}");
            sb.AppendLine("==================");

            return sb.ToString();
        }


        public string GetDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("==================");
            sb.AppendLine($"Nombre: {_nombre}");
            sb.AppendLine($"Apellido: {_apellido}");
            sb.AppendLine($"Legajo: {_legajo}");
            sb.AppendLine("==================");

            return sb.ToString();
        }
        public bool Equals(Persona persona)//Compara dos objetos si son iguales
        {                                   //Utilizamos para no repetir el codigo
            return _legajo == persona._legajo;
        }
        #region Sobrecarga Operadores
        public static bool operator ==(Persona p1, Persona p2)
        {
            return p1.Legajo == p2.Legajo;
        }
        public static bool operator !=(Persona p1, Persona p2)
        {
            return !(p1 == p2);
        }
        
        public static int operator +(Persona p1, Persona p2)
        {
            return p1.Legajo + p2.Legajo;
        }
        //public static int operator +(Persona p1, int numero)
        //{
        //    //return p1.Legajo + numero;
        //    return p1.Promedio + numero;
        //}
        public static int operator +( int numero,Persona p1 )
        {
            return numero + p1.Promedio;
        }
        public static int operator +(Persona p1, int numero)
        {
            //p1.Promedio += numero;//asignando .le cambio el valor porque tiene un seter
            return p1.Promedio + numero ;
        }
        public static Persona operator ++(Persona p1)
        {
            
           p1.Promedio += 1;
            return p1; 
        }
        public static Persona operator --(Persona p1)
        {

            p1.Promedio += 0;
            return p1;
        }

        #endregion
    }
}
