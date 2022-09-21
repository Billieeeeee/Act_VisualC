using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int a = 5;
            int b = 6;
            int d = a;
            int e = a / b;
            int x = a + b * 3;

            Console.WriteLine("Hola mundo" + " x " + "para navidad");
            Console.WriteLine($"Hola mundo {x} para navidad");

            soyLaFirma();

        }

        public static void soyLaFirma()
        {

            Console.WriteLine("Soy la llamada de la firma");
<
        }
    }
}
