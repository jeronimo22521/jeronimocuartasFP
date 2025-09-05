namespace _10._whilees
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*  Crear un algoritmo que permita calcular la factorial de un número dado por el usuario. (5! = 1 * 2 * 3 * 4 * 5)*/

            Console.WriteLine("=== CALCULADORA DE FACTORIAL ===");

            int numero;
            bool entradaValida = false;

           
            do
            {
                Console.Write("Ingrese un número entero no negativo: ");
                string input = Console.ReadLine();

              
                if (int.TryParse(input, out numero) && numero >= 0)
                {
                    entradaValida = true;
                }
                else
                {
                    Console.WriteLine("Error: Debe ingresar un número entero no negativo.");
                    Console.WriteLine();
                }
            } while (!entradaValida);

        
            long factorial = CalcularFactorial(numero);

            
            Console.WriteLine();
            Console.WriteLine($"El factorial de {numero}! es: {factorial}");

            
            if (numero <= 10)
            {
                Console.Write("Proceso: ");
                for (int i = 1; i <= numero; i++)
                {
                    Console.Write(i);
                    if (i < numero)
                    {
                        Console.Write(" × ");
                    }
                }
                Console.WriteLine($" = {factorial}");
            }
        }

        static long CalcularFactorial(int n)
        {
            if (n == 0 || n == 1)
            {
                return 1;
            }

            long resultado = 1;
            for (int i = 2; i <= n; i++)
            {
                resultado *= i;
            }
            return resultado;
        }
    }
}
