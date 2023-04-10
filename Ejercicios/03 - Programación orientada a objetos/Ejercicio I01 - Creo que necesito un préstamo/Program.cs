namespace Ejercicio_I01___Creo_que_necesito_un_préstamo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cuenta cuentaUno = new Cuenta("PerezS", 5253.40);
            Cuenta cuentaDos = new Cuenta("ARli", 123.1);
            Cuenta cuentaTres = new Cuenta("Mac", 0);


            Console.WriteLine(cuentaUno.Mostrar());
            Console.WriteLine(cuentaDos.Mostrar());
            Console.WriteLine(cuentaTres.Mostrar());

            cuentaTres.Ingresar(23200.21);
            cuentaDos.Ingresar(200.80);
            cuentaUno.Retirar(200);

            Console.WriteLine(cuentaUno.Mostrar());
            Console.WriteLine(cuentaDos.Mostrar());
            Console.WriteLine(cuentaTres.Mostrar());

            cuentaTres.Retirar(23200.21);
            cuentaDos.Retirar(200.80);
            cuentaUno.Retirar(10000);

            Console.WriteLine(cuentaUno.Mostrar());
            Console.WriteLine(cuentaDos.Mostrar());
            Console.WriteLine(cuentaTres.Mostrar());

        }
    }
}