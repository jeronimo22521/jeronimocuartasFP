namespace _13.whiles5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Escribir un algoritmo que cuente cuántos números pares hay en un rango de números del 1 al número n. 

            int contador = 1;
            int cantidapares = 0;
            int rango = 0;

            Console.WriteLine("ingrese el rango  de numeros a evaluar:");
            rango=int.Parse(Console.ReadLine());

            while (contador <=rango)
            {
                if (contador%2==0)
                {
                    cantidapares++;

                }
                  contador++; 
            }
            Console.WriteLine($"la cantidad de numeros pares del 1 hasta {rango}, es: {cantidapares}");

             Realizar un algoritmo que le pida al usuario ingresar por teclado números enteros al azar.Al usuario le corresponde ingresar la cantidad de números que va a introducir.
 El algoritmo debe escribir en pantalla: 
 La cantidad de números introducidos que son mayores que 0
 La cantidad de números introducidos menores que 0
 La cantidad de números iguales a 0.*/

            int cantidad;
            int numero;
            int mayores_cero = 0;
            int menores_cero = 0;
            int iguales_cero = 0;

            Console.Write("CONTADOR DE NUMEROS");
            Console.Write("");

     
            Console.Write("¿Cuantos numeros vas a introducir? ");
            cantidad = Convert.ToInt32(Console.ReadLine());

            
            for (int i = 1; i <= cantidad; i++)
            {
                Console.Write("Ingresa el numero " + i + ": ");
                numero = Convert.ToInt32(Console.ReadLine());

               
                if (numero > 0)
                {
                    mayores_cero = mayores_cero + 1;
                }
                if (numero < 0)
                {
                    menores_cero = menores_cero + 1;
                }
                if (numero == 0)
                {
                    iguales_cero = iguales_cero + 1;
                }
            }

         
            Console.Write("RESULTADOS");
            Console.Write("Numeros mayores que 0: " + mayores_cero + "");
            Console.Write("Numeros menores que 0: " + menores_cero + "");
            Console.Write("Numeros iguales a 0: " + iguales_cero + "");
        }
    }
}   
