using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I04___Invento_argentino
{
    internal class Boligrafo
    {
        public const short cantidadTintaMaxima = 100;
        private ConsoleColor color;
        private short tinta;

        public Boligrafo(ConsoleColor color, short tinta)
        {
            this.color = color;
            this.tinta = tinta;
        }
        public ConsoleColor GetColor()
        {
            return color;
        }
        public short GetTinta()
        {
            return tinta;
        }
        public bool Pintar(short gasto, out string dibujo)
        {

        }
        public void Recargar()
        {

        }
        private void SetTinta(short tinta)
        {
            if(tinta != 0)
            {
                this.tinta = tinta;
            }
            else
            {

            }
        }
    }
    
}
