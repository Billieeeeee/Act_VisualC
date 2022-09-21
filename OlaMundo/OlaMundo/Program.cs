using System;

namespace OlaMundo
{
    class Program
    {
        static void Main(string[] args)
        {

            int horasTrabajadas;
            float costHora, sueldo;
            String linea;

            Console.WriteLine("Ingrese horas trabajadas: ");
            linea = Console.ReadLine();


            //Conversion de String a int
            horasTrabajadas = int.Parse(linea);
            Console.WriteLine("Ingrese el pago por hora");
            linea = Console.ReadLine();


            //conversion de String a float
            costHora = float.Parse(linea);
            sueldo = horasTrabajadas * costHora;

            if(sueldo > 3000)
            {
            
                sueldo = sueldo * 1.08F; //conversión a float

                if(sueldo > 5000)
                {

                    Console.WriteLine("Tiene que pagar sus impuestos por ser rico");

                }
                else
                {

                    Console.WriteLine("¡Tiene que pagar impuestos!");

                }

            }

            Console.WriteLine("Sueldo total: " + sueldo);
            if(sueldo > 5000 && sueldo < 10000)
            {

                Console.WriteLine("Empleado rango S");

            }

            if(sueldo < 3000 || sueldo <= 0)
            {

                Console.WriteLine("Pasa por tu despensa");

            }

            int x = 1;
            while(x <= 100)
            {
                Console.WriteLine(x);
                Console.Write("     ");
                x++;
            }

            Console.ReadKey(); /*espera un espacio*/
            //&& multiplicacion y "or" es una suma
        }
    }
}
