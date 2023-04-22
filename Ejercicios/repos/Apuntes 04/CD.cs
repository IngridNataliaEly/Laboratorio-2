namespace Apuntes_04
{
    internal class CD
    {

        
        public string Titulo { get; set; }//propiedad
        //init = solo nos permite inicializarlo(en lugar de set )

        public int Anio
        {//-*-*-*-*-*-*-*-*-*-*-*-*--*-*-*-*-*-*-*-*-**-*-*-*-*-*ESTO ES UNA PROPIEDAD NOO UN ATRIBUTO
            get => _anio;
            set => _anio = value > 1900 ? value : 0;
        }
        /**get { return _anio; }
         * set {
            if (value > 1900)//le puedo agregar condiciones 
            {
                _anio = value;
            }
            else
            {
                _anio = 0;
                // throw new InvalidOperationException();  exepcion FRENA EL PROGRAMA CUANDO ES ERROR
            }
        /** set { _anio = value; } O 
         * public int GetAnio() ME ESTOY AHORRANDO CODIGO
        {
            return _anio;
        }
         * 
     
         * public int SetAnio(int anio) ES LO MISMO QUE HACER ESTO 
        {
            _anio = anio;
        } */
    

        private int _anio; //atributos privados le ponemos _ guion bajo-*-*-**-*-* ESTO ES UN ATRIUTO

        public int Id { get => _id; }
        private int _id;//campo, atributo privado

        public CD(int total)
        {
            _id = total;
        }




    }

}

