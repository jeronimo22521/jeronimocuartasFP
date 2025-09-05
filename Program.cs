namespace _11.ciclodewhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Realizar un algoritmo que pida números enteros positivos y los sume, hasta que se ingrese un número entero negativo. Se debe mostrar por pantalla el total de la suma de los números ingresados. */

            Console.WriteLine(" SUMADORA DE NÚMEROS POSITIVOS ");
            Console.WriteLine("Ingrese números enteros positivos para sumar.");
            Console.WriteLine("Ingrese un número negativo para terminar y ver el resultado.");
            Console.WriteLine(new string('-', 50));

            int suma = 0;
            int numero;
            int contador = 0;

            do
            {
                Console.Write($"Ingrese el número #{contador + 1}: ");
                string input = Console.ReadLine();

                
                if (int.TryParse(input, out numero))
                {
                    if (numero >= 0)
                    {
                        suma += numero;
                        contador++;
                        Console.WriteLine($"[ Número agregado. Suma parcial: {suma}");
                    }
                    else
                    {
                        Console.WriteLine(" :D Número negativo detectado. Finalizando...");
                    }
                }
                else
                {
                    Console.WriteLine("X Error: Debe ingresar un número entero válido.");
                }

                Console.WriteLine();

            } while (numero >= 0);

            // Mostrar resultados
            Console.WriteLine(new string('=', 50));
            Console.WriteLine("RESULTADOS FINALES:");
            Console.WriteLine($"Cantidad de números ingresados: {contador}");
            Console.WriteLine($"Suma total de números positivos: {suma}");

            if (contador > 0)
            {
                double promedio = (double)suma / contador;
                Console.WriteLine($"Promedio de los números: {promedio:F2}");
            }


        }

    }
}
