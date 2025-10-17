namespace _20_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Un equipo de futbol jugó 30 partidos en el año, se desea crear un algoritmo que permita saber:   
  El número de partidos perdidos  
  El número de partidos empatados  
  El número de partidos ganados  
  El porcentaje de partidos perdidos  
  El porcentaje de partidos empatados  
  El porcentaje de partidos ganados */

            int ganados = 0, perdidos = 0, empatados = 0;
            int contador = 0;
            int totalPartidos = 30;

            do
            {
                Console.Write($"Resultado del partido #{contador + 1} (G = Ganado, P = Perdido, E = Empatado): ");
                string resultado = Console.ReadLine().ToUpper();

                if (resultado == "G")
                {
                    ganados++;
                }
                else if (resultado == "P")
                {
                    perdidos++;
                }
                else if (resultado == "E")
                {
                    empatados++;
                }
                else
                {
                    Console.WriteLine("Opción inválida, no se contabiliza este partido.");
                    continue; 
                }

                contador++;
            } while (contador < totalPartidos);

            double porcentajeGanados = (ganados * 100.0) / totalPartidos;
            double porcentajePerdidos = (perdidos * 100.0) / totalPartidos;
            double porcentajeEmpatados = (empatados * 100.0) / totalPartidos;

          
            Console.WriteLine(" RESULTADOS ");
            Console.WriteLine("Partidos ganados: " + ganados);
            Console.WriteLine("Partidos perdidos: " + perdidos);
            Console.WriteLine("Partidos empatados: " + empatados);

            Console.WriteLine("\nPorcentaje ganados: " + porcentajeGanados + "%");
            Console.WriteLine("Porcentaje perdidos: " + porcentajePerdidos + "%");
            Console.WriteLine("Porcentaje empatados: " + porcentajeEmpatados + "%");

        }
    }
}
