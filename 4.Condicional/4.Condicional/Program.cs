namespace _4.Condicional
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*CONDICIONAL SIMPLE
            string nombre = "";
            int sueldo = 0;

            Console.WriteLine("ingrese el nombre");
            nombre = Console.ReadLine();

            Console.WriteLine("ingrese el sueldo");
            sueldo = Int32.Parse(Console.ReadLine());

            if (sueldo > 3000)
            {
                //Verdadera
                Console.WriteLine($"La persona {nombre}, debe abonar impuestos");
            }
            else
            {
                //falsa
                Console.WriteLine($"La persona {nombre} no abona impuestoos");<
            }*/
            /*
            string nombre = "";
            int edad = 0;

            Console.WriteLine("ingrese el nombre");
            nombre = Console.ReadLine();
            Console.WriteLine(nombre);

            Console.WriteLine("ingrese su edad");

            edad = int.Parse(Console.ReadLine());

            if (edad > 18)
            {
                Console.WriteLine("bienvenido a mi sitio web");
            }
            else
            {
                Console.WriteLine("No eres apto para el contenido de este sitio web");
            }
            */

            int numero1 = 0;
            int numero2 = 0;

            Console.WriteLine("ingrese el numero 1");
            numero1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("ingrese el numero 2");
            numero2 = Int32.Parse(Console.ReadLine());

            if (numero1 > numero2)
            {
                Console.WriteLine($"Suma{numero1} + {numero2}, Diferencia: {numero1 - numero2}" );
            }
            else
            {
                Console.WriteLine($"Producto: {numero1 * numero2}, División: {numero1 / numero2}");
            }

        }

    }


}

