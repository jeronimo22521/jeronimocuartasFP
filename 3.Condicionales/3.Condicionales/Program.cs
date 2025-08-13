namespace _3.Condicionales
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //CONDICIONAL SIMPLE
            string nombre = "";
            int sueldo = 0;

            Console.WriteLine("ingrese el nombre");
            nombre = Console.ReadLine();//Todo lo que yo leo desde la consola llega como string
            Console.WriteLine(nombre);
            Console.WriteLine("ingrese el sueldo");
            sueldo = Convert.ToInt32(Console.ReadLine());

            if (sueldo > 3000)
            {
                Console.WriteLine($"La persona {nombre}, debe abonar impuestos");
            }

            //Crea un adgoritmo que lea la edad de un usuario, si el usuarioes mayor de 18 se debe mostrar el siguiente mensaje; "bienvenido al sitio web" /

            int edad = 0;
            Console.WriteLine("ingrese su edad");

            edad = int.Parse(Console.ReadLine());

            if (edad > 18)
            {
                Console.WriteLine("bienvenido al sitio web");
            }
            else
            {
                Console.WriteLine("acceso denegado, debes ser mayor de 18 para acceder al sitio web");
            }
        }
        


       
        
            
      
    }
}
