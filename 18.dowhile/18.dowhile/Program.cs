namespace _18.dowhile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Algoritmo que le pida a un grupo de usuarios su nombre, número de cuenta y saldo; para cada usuario se debe hacer lo siguiente: 
Si el saldo es mayor a 3’000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y “Es apto para el crédito” 
Si el saldo es menor a 3’000.000, sacar un mensaje que diga el nombre del usuario, el número de cuenta, el saldo y “No es apto para el crédito” 
El algoritmo debe permitir preguntar la información de usuarios, hasta que se le indique que ya no se desea preguntar más. 
Además, el algoritmo debe permitir mostrar el número de usuarios a los que se le pregunto por la información, y debe mostrar el promedio de los saldos. */



            int contadorUsuarios = 0;
            double sumaSaldos = 0;
            string opcion;

            do
            {
                Console.WriteLine("Ingrese el nombre del usuario:");
                string nombre = Console.ReadLine();

                Console.WriteLine("Ingrese el número de cuenta:");
                string numeroCuenta = Console.ReadLine();

                Console.WriteLine("Ingrese el saldo:");
                double saldo = Convert.ToDouble(Console.ReadLine());

                // Contador y suma para el promedio
                contadorUsuarios++;
                sumaSaldos += saldo;

                // Verificación de crédito
                if (saldo > 3000000)
                {
                    Console.WriteLine($"Nombre: {nombre}, Cuenta: {numeroCuenta}, Saldo: {saldo}, Es apto para el crédito");
                }
                else
                {
                    Console.WriteLine($"Nombre: {nombre}, Cuenta: {numeroCuenta}, Saldo: {saldo}, No es apto para el crédito");
                }

                Console.WriteLine("¿Desea ingresar otro usuario? (SI/NO):");
                opcion = Console.ReadLine().ToUpper();

            } while (opcion == "SI");

            // Resultados finales
            if (contadorUsuarios > 0)
            {
                double promedio = sumaSaldos / contadorUsuarios;
                Console.WriteLine($"\nNúmero de usuarios ingresados: {contadorUsuarios}");
                Console.WriteLine($"Promedio de los saldos: {promedio}");
            }
            else
            {
                Console.WriteLine("No se ingresaron usuarios.");
            }

         
        }
    }
}
