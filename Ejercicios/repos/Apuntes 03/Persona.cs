using System.Text;

namespace Apuntes_03
{
    internal class Persona//Es la generalizacion (en singular y con mayuscula)
    {
        public string Nombre{ get => _nombre; set => _nombre = value; }//prpiedad
        private string _nombre; //Atributo, la caracteristca o estado de un objeto
        
        
        public string Apellido { get => _apellido; set => _apellido = value; }
        private string _apellido;
        
        
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
            Nombre =  nombre;
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
    }
}
