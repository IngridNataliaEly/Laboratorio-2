using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_I02___Desea_continuar
{
    internal class Validador
    {
        static public bool ValidarRespuesta(char respuesta)
        {
            if(respuesta == 's' || respuesta =='S')
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
