namespace Parcial_1_condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Ingresar los siguientes datos del empleado:

Nombre del empleado.
Número de años trabajados en la empresa.
Calificación del año actual (0.0, 0.4, 0.6, 1.0).
Calificación del año anterior (debe ser uno de los mismos valores anteriores).

2. Validar que las calificaciones ingresadas estén entre los valores permitidos.

Si la calificación actual no corresponde a ninguno de los valores válidos (0.0, 0.4, 0.6, 1.0), el programa debe mostrar un mensaje de error y terminar inmediatamente.

3. Calcular el promedio de las dos calificaciones (año actual y anterior).

4. Según el número de años trabajados y el promedio de calificación, determinar el porcentaje de aumento salarial utilizando las siguientes reglas:

añosTrabajados < 1  =   0%
añosTrabajados > 5  =   30%
0 < añosTrabajados <= 5 y 0 <= promedioCalificación < 0.4    =    5%
0 < añosTrabajados <= 5 y 0.4 <= promedioCalificación < 0.6    =   10%
0 < añosTrabajados <= 5 y 0.6 <= promedioCalificación <= 1.0   =   20%

     5. Todos los empleados tienen un sueldo base fijo de $2.500.000.
        El aumento se calcula como:  valorAumento = sueldoBase×(porcentajeAumento/100​)
                                   
6. El programa debe mostrar al final:
Nombre del empleado.
Promedio de la calificación.
Porcentaje de aumento aplicado.
Valor del aumento en pesos.*/

            Console.Write("Ingrese el nombre del empleado: ");
            string nombre = Console.ReadLine();

            Console.Write("Ingrese el número de años trabajados: ");
            int añosTrabajados = int.Parse(Console.ReadLine());

            Console.Write("Ingrese la calificación del año actual (0.0, 0.4, 0.6, 1.0): ");
            double calificacionActual = double.Parse(Console.ReadLine());

            Console.Write("Ingrese la calificación del año anterior (0.0, 0.4, 0.6, 1.0): ");
            double califAnterior = double.Parse(Console.ReadLine());


            if ((calificacionActual != 0.0 && calificacionActual != 0.4 && calificacionActual != 0.6 && calificacionActual != 1.0) ||
                (califAnterior != 0.0 && califAnterior != 0.4 && califAnterior != 0.6 && califAnterior != 1.0))
            {
                Console.WriteLine(" Error: Una o ambas calificaciones no son válidas.");
                return;
            }


            double promedio = (calificacionActual + califAnterior) / 2;


            double porcentajeAumento = 0;

            if (añosTrabajados < 1)
            {
                porcentajeAumento = 0;
            }
            else
            {
                if (añosTrabajados > 5)
                {
                    porcentajeAumento = 30;
                }
                else // 0 < añosTrabajados <= 5
                {
                    if (promedio >= 0 && promedio < 0.4)
                    {
                        porcentajeAumento = 5;
                    }
                    else if (promedio >= 0.4 && promedio < 0.6)
                    {
                        porcentajeAumento = 10;
                    }
                    else if (promedio >= 0.6 && promedio <= 1.0)
                    {
                        porcentajeAumento = 20;
                    }
                }
            }

            // 5. Sueldo base y aumento
            double sueldoBase = 2500000;
            double valorAumento = sueldoBase * (porcentajeAumento / 100);

            // 6. Mostrar resultados
            Console.WriteLine("\n--- RESULTADOS ---");
            Console.WriteLine("Empleado: " + nombre);
            Console.WriteLine("Promedio de calificación: " + promedio.ToString("F2"));
            Console.WriteLine("Porcentaje de aumento aplicado: " + porcentajeAumento + "%");
            Console.WriteLine("Valor del aumento: $" + valorAumento.ToString("N0"));
        }

    }
}

          


       
   
