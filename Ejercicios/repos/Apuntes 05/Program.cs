using System.Collections;

namespace Apuntes_05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = { 1, 2 };
            int[] numeros2 = new int[2];

            //asignarles valor 
            numeros2[0] = 1;
            numeros2[1] = 2;
            numeros2[2] = 3;

            //podemos iterarlos con un FOR
            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine(numeros[i]);                  
            }
            //permite recorrer todos los iterables (son los q implementan una interfas )
            //donde no necesito acceder al indice
            foreach (var item in numeros2)
            {
                Console.WriteLine(item);
            }
            //ESTOS TIENEN ALGO MALO ES UN TAMAÑO FIJO 
            int[,] bidi = { { 1, 2 }, { 3, 4 } }; //ARRAY DE ARRAYS LA , INDICA LA CANTIDAD X,Y
            //podemos remplazarlos por 
            // { objeto1, objeto2, objeto3, objeto4}

            //Listas =(Objeto)La  Instancia de un objeto, en una clase con un monton de metodos para trabajar con datos.
            //Coleciones = Tamaño dinamico no vamos a necesitar saber antes cuantos elementos vamos a tener a medidida que se va
            //guardando va generando en memoria dinamica .

            //todos los elementos van a estar enumerados ----Son en base 0 al igual que el array 
            // Colecion = Tipos 1-GENERICAS 2-NO GENERICAS 3- CONCURRENTES 4-INMUTABLES
            ArrayList arrayList = new ArrayList(); //Cada vez que hacemos new se reserva espacio memoria para un objeto en este caso de tipo arraylist;. 

            //arrayList.Add(bidi);//Agrega un objeto al final del arraylist
            //arrayList.AddRange(bidi);//Agrega una colecion de elemento
            //arrayList.Contains(bidi);//Determina si un elemento esta contenido en la lista 
            //arrayList.CopyTo(bidi);//Hacer una copia Esto es un objeto el obj se pasa por referncia y es mutable.
            //arrayList.Count();//Ver la cantidad de elementos que tiene.

            arrayList[0] = 1;

            arrayList.Add(12);

            foreach (var item in arrayList)//me lo devuelve en la varibale item
            {
                var i = arrayList.IndexOf(item);//
                Console.WriteLine(item);
            }


        }
    }
}