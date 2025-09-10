namespace _19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*En un grupo de 100 alumnos, se desea saber cuántos de los estudiantes son hombres y cuántos son mujeres, además se desea saber cuántos son mayores de edad y cuántos no.*/

            int hombres = 0, mujeres = 0;
            int mayores = 0, menores = 0;
            int contador = 0;

            do
            {
                Console.WriteLine($"Ingrese los datos del alumno #{contador + 1}:");

              
                Console.Write("Digite el sexo (H para hombre, M para mujer): ");
                string sexo = Console.ReadLine().ToUpper();

                if (sexo == "H")
                {
                    hombres++;
                }
                else if (sexo == "M")
                {
                    mujeres++;
                }
                else
                {
                    Console.WriteLine("Opción inválida, no se contabiliza sexo.");
                }

                
                Console.Write("Digite la edad: ");
                int edad = int.Parse(Console.ReadLine());

                if (edad >= 18)
                {
                    mayores++;
                }
                else
                {
                    menores++;
                }

                contador++;

                Console.WriteLine(); 
            } while (contador < 100);

            Console.WriteLine("----- RESULTADOS -----");
            Console.WriteLine("Total de hombres: " + hombres);
            Console.WriteLine("Total de mujeres: " + mujeres);
            Console.WriteLine("Mayores de edad: " + mayores);
            Console.WriteLine("Menores de edad: " + menores);



        }
    }
}
