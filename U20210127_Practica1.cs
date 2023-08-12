using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //Declaracion de variables
            string? nombre;
            int edad;
            string? direccion;
            int telefono;
            string? universidad;
            string? carrera;
            string? facultad;
            int ciclo;

            Console.WriteLine("\n***************Practica 1 - Programacion estructurada***************\n");
            Console.WriteLine("\n");
            Console.WriteLine("Ingrese su nombre completo:");//Obtener datos
            nombre = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese su edad:");//Obtener datos
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese su direccion:");//Obtener datos
            direccion = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese su numero de telefono:");//Obtener datos
            telefono = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese la universidad donde estudia:");//Obtener datos
            universidad = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese la carrera:");//Obtener datos
            carrera = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese la facultad:");//Obtener datos
            facultad = Convert.ToString(Console.ReadLine());
            Console.WriteLine("\n");

            Console.WriteLine("Ingrese el ciclo de estudio:");//Obtener datos
            ciclo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("\n");

            //Imprimiendo datos
            Console.WriteLine("Su nombre es: " + nombre);
            Console.WriteLine("Su edad es: " + edad);
            Console.WriteLine("Su direccion es: " + direccion);
            Console.WriteLine("Su telefono es: " + telefono);
            Console.WriteLine("Estudia en la universidad tal: " + universidad);
            Console.WriteLine("Su carrera es: " + carrera);
            Console.WriteLine("Facultad que pertenece es: " + facultad);
            Console.WriteLine("Su ciclo cursando es: " + ciclo);
            Console.WriteLine("Su ciclo cursando es: " + ciclo);

            
        }
    }
}