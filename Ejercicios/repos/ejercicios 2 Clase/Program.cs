using System;
//Ingrid Natalia Ely
//2° E
namespace ejercicios_2_Clase
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int numero; 
            int max = 0;
            int min = 0;

            int acumulador = 0;
            float promedio = 0;
            Console.WriteLine("Ingresa 5 numeros");

            for (int i = 0; i < 5; i++)
            {
                numero = Convert.ToInt32(Console.ReadLine());

                if(i == 0)
                {
                    max = numero;
                    min = numero;
                }
                else
                {
                    if (max < numero)
                    {
                        max = numero;
                    }
                    else if(min > numero)
                    {
                        min = numero;
                    }

                }
                acumulador += numero;    
            }
            promedio = (float)acumulador / 5;
            Console.WriteLine("Maximo {0}, minimo{1}, promedio {2}", max, min,promedio);
            Console.ReadKey();

        }
    }
}