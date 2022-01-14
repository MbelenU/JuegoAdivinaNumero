using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            // int numero = Convert.ToInt32(Console.ReadLine());
            String nombre;
            int rta = 0;
            Console.WriteLine("Introduzca su nombre: ");
            nombre = Console.ReadLine();
            Console.WriteLine($"Hola {nombre} Vamos a jugar un juego");

            Random numero = new Random();
            int aleatorio = numero.Next(0, 100);
            int minumero = 101;
            int intentos = 0;

            Console.WriteLine("Intenta adivinar el numero que estoy pensando! Introduci un numero entre 0 y 100:");
            do { }
            do
            {
                intentos++;
                minumero = int.Parse(Console.ReadLine());
                if (minumero > aleatorio) Console.WriteLine("El numero es mas bajo");
                if (minumero < aleatorio) Console.WriteLine("El numero es mas alto");


            } while (aleatorio != minumero);

            Console.WriteLine($"Correcto {nombre}... Necesitaste {intentos} intentos...");
        } while (rta==1);
        }
    }
}
