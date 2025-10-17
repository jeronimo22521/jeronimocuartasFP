using System.ComponentModel.Design;
using System.Timers;

namespace parcial_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Se requiere diseñar un programa para procesar las notas definitivas de Física de un grupo de 15 estudiantes. Las calificaciones están en un rango de 0.0 a 5.0.
 El programa debe realizar las siguientes tareas:
 Ingresar por teclado la nota final de cada estudiante.
 Calcular el promedio general del grupo.
 Clasificar a cada estudiante según su calificación en una de las siguientes categorías:
 Excelente: nota ≥ 4.8
 Bueno: 4.0 ≤ nota ≤ 4.7
 Regular: 3.0 ≤ nota ≤ 3.9
 Descuidado: nota ≤ 2.9
 Contar y mostrar por pantalla el número total de estudiantes en cada categoría.
 Mostrar en pantalla el promedio del grupo y la cantidad de alumnos clasificados en cada nivel.*/

          
           
            int estudiantes = 0;
            const int N = 15;
            double suma = 0;
            int excelente = 0, bueno = 0, regular = 0, descuidado = 0;
          

            do
            {
                double nota;
                

                do
                {

                    Console.WriteLine($"ingrese la nota del estudiante {estudiantes + 1} (0.0 a 5.0) ");
                    nota = Convert.ToDouble(Console.ReadLine());




                } while (nota < 0.0 || nota > 5.0);

                suma += nota;

                if (nota >= 4.8)
                    excelente++;

                
                
                if (nota >= 4.0)
                    bueno++;

                
                
                if (nota >= 3.0)
                    regular++;

                else
                    descuidado++;


                estudiantes++; 


            } while (estudiantes < N);


            Console.WriteLine(" Resultados ");

          

            Console.WriteLine($"Excelente (≥ 4.8): {excelente}");

            Console.WriteLine($"Bueno (4.0 – 4.7): {bueno}");

            Console.WriteLine($"Regular (3.0 – 3.9): {regular}");

            Console.WriteLine($"Descuidado (≤ 2.9): {descuidado}");








        }
    }
}
