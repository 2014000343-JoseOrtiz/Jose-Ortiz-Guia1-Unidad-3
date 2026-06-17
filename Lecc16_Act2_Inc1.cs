using System;

class Program
{
    static void Main()
    {
        int[] edades = new int[7];
        int cantidadMayoresEdad = 0;

        for (int i = 0; i < 7; i++)
        {
            Console.Write("Ingrese la edad de la persona " + (i + 1) + ": ");
            edades[i] = Convert.ToInt32(Console.ReadLine());

            if (edades[i] >= 18)
            {
                cantidadMayoresEdad++;
            }
        }

        Console.WriteLine("Cantidad de personas mayores de edad: " + cantidadMayoresEdad);
        Console.ReadKey();
    }
}