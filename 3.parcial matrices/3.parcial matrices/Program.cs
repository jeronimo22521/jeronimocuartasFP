using System.Globalization;

namespace _3.parcial_matrices
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Registro y análisis de calificaciones de estudiantes
          Implemente un programa que gestione la información académica de 5 estudiantes, almacenando sus datos en una matriz estructurada y realizando cálculos sobre sus calificaciones.
         Requisitos del programa:
         Creación de la matriz:
         Utilice una matriz de 6 columnas por 6 filas (1 fila para encabezados y 5 filas para datos de estudiantes).
           La primera fila debe contener los encabezados de las columnas, en el siguiente orden:
         | Nombre del Estudiante | Grado | Nota Parcial 1 | Nota Parcial 2 | Examen Final | Nota Final |
           Ingreso de datos:
           Para cada uno de los 5 estudiantes, el programa debe solicitar por teclado:
          Nombre completo del estudiante.
          Grado (solo se permiten los grados: 6°, 7°, 8°, 9°). Validar la entrada.
           Nota del Parcial 1 (valor decimal entre 0.0 y 5.0). Validar la entrada.
           Nota del Parcial 2 (valor decimal entre 0.0 y 5.0). Validar la entrada.
           Nota del Examen Final (valor decimal entre 0.0 y 5.0). Validar la entrada.
          Calcular la Nota Final como el promedio de las tres notas (Parcial 1, Parcial 2 y Examen Final) .
          Visualización de la matriz:
            Una vez ingresados todos los datos, mostrar en pantalla la matriz completa con los encabezados y los datos de cada estudiante.
            Análisis de calificaciones:
           Determinar y mostrar en pantalla:
           El nombre del estudiante con la mayor nota final.
           Consideraciones adicionales:
           La matriz será una mezcla de texto y números, por lo tanto, se recomienda tratar los datos de la matriz, como tipo string y convertir las notas a tipos numéricos para realizar los cálculos.
           Use validación de entrada para garantizar que los datos del usuario cumplan con los requisitos establecidos.*/

            string[,] matriz = new string[6, 6];

            
            matriz[0, 0] = "Nombre del Estudiante";
            matriz[0, 1] = "Grado";
            matriz[0, 2] = "Nota Parcial 1";
            matriz[0, 3] = "Nota Parcial 2";
            matriz[0, 4] = "Examen Final";
            matriz[0, 5] = "Nota Final";

            string[] gradosValidos = { "6", "7", "8", "9" };
            double mayorNotaFinal = -1;
            string estudianteMayorNota = "";

            for (int i = 1; i <= 5; i++)
            {
                Console.WriteLine($"\nEstudiante #{i}");

                
                Console.Write("Nombre completo: ");
                matriz[i, 0] = Console.ReadLine();

              
                string grado;
                while (true)
                {
                    Console.Write("Grado (6, 7, 8, 9): ");
                    grado = Console.ReadLine();
                    if (Array.Exists(gradosValidos, g => g == grado))
                        break;
                    Console.WriteLine("Grado inválido. Intente de nuevo.");
                }
                matriz[i, 1] = grado;

            //aqui las notas 
                double[] notas = new double[3];
                for (int j = 0; j < 3; j++)
                {
                    string nombreNota = j == 0 ? "nota Parcial 1" : (j == 1 ? "nota Parcial 2" : "examen Final");
                    while (true)
                    {
                        Console.Write($"{nombreNota} (0.0 - 5.0): ");
                        string entrada = Console.ReadLine();
                        if (double.TryParse(entrada, NumberStyles.Float, CultureInfo.InvariantCulture, out double nota) && nota >= 0.0 && nota <= 5.0)
                        {
                            notas[j] = nota;
                            matriz[i, 2 + j] = nota.ToString("0.00", CultureInfo.InvariantCulture);
                            break;
                        }
                        Console.WriteLine("nota invalida. intente de nuevo.");
                    }
                }

                
                double notaFinal = Math.Round((notas[0] + notas[1] + notas[2]) / 3, 2);
                matriz[i, 5] = notaFinal.ToString("0.00", CultureInfo.InvariantCulture);

               
                if (notaFinal > mayorNotaFinal)
                {
                    mayorNotaFinal = notaFinal;
                    estudianteMayorNota = matriz[i, 0];
                }
            }

            
            Console.WriteLine("\nMATRIZ DE CALIFICACIONES:");
            for (int fila = 0; fila < 6; fila++)
            {
                for (int col = 0; col < 6; col++)
                {
                    Console.Write($"{matriz[fila, col],-22}");
                }
                Console.WriteLine();
            }

            
            Console.WriteLine($"\nEl estudiante con la mayor nota final es: {estudianteMayorNota} ({mayorNotaFinal:0.00})");
        }

    
    }
}

