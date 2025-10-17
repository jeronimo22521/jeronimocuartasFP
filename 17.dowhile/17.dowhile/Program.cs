namespace _17.dowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //algoritmo que genra y suma los primeros 5 numeors enteros 
/*
            int contador = 0;
            int acumulador = 0;

            do
            {

                contador++;
                acumulador = acumulador + contador;
            } while (contador < 5);

            Console.WriteLine("la suma de los cinco primeros numeros enteros es: " + acumulador);

            Algoritmo que solicita un número y genere su correspondiente tabla de multiplicar desde el 1 hasta el 10. Y así sucesivamente hasta que el usuario ya no desee continuar generando tablas de multiplicar. */

            int contador = 1;
            int numero = 0;
            string respuesta = "";
            do
            {
                Console.WriteLine("ingrese un numero para calcular su tabla de multiplicar:");
                numero = int.Parse(Console.ReadLine());

                do
                {
                    Console.WriteLine($"{numero} x {contador} = {numero * contador}");
                    contador++;
                } while (contador <= 10);

                contador = 1;
                Console.WriteLine("desea generar una nueva tabla de multiplicar s:si , n=no");
                respuesta = Console.ReadLine().ToLower();

            } while (respuesta == "s");
           

        }
    }
}
