using System;

namespace MyApp// Note: actual namespace depends on the project name.
{
    internal class Program
    {
         static void Main(string[] args)
        {
            //Declarion de variables
            string? nombre;
            int edad;
            string? direccion;
            int telefono;
            string? universidad;
            string? carrera;
            string? facultad;
            int ciclo_estudio;

            Console.WriteLine("\n**********************Practica 1 - Programacion Estructurada**********************");
            Console.WriteLine("\nIngrese su nombre completo:");//Captura de datos desde consola
            nombre = Convert.ToString(Console.ReadLine());
            Console.WriteLine("");//Espacio

            Console.WriteLine("Ingrese su edad:");//Captura de datos desde consola
            edad = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");//Espacio

            Console.WriteLine("Ingrese su direccion de residencia:");//Captura de datos desde consola
            direccion = Convert.ToString(Console.ReadLine());
            Console.WriteLine("");//Espacio

            Console.WriteLine("Ingrese su numero de telefono:");//Captura de datos desde consola
            telefono = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");//Espacio

            Console.WriteLine("Ingrese el nombre de la universidad donde estudias:");//Captura de datos desde consola
            universidad = Convert.ToString(Console.ReadLine());
            Console.WriteLine("");//Espacio
            
            Console.WriteLine("Ingrese su carrera de estudio:");//Captura de datos desde consola
            carrera = Convert.ToString(Console.ReadLine());
            Console.WriteLine("");//Espacio

            Console.WriteLine("Ingrese la facultad a la que pertenece:");//Captura de datos desde consola
            facultad = Convert.ToString(Console.ReadLine());
            Console.WriteLine("");//Espacio

            Console.WriteLine("Ingrese el ciclo cursando acualmente de la carrera:");//Captura de datos desde consola
            ciclo_estudio = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("");//Espacio

            Console.WriteLine("**********************Datos Personales**********************");
            Console.WriteLine("Su nombre es: " + nombre);//Impresion de datos
            Console.WriteLine("Su edad es: " + edad);//Impresion de datos
            Console.WriteLine("Su direccion es: " + direccion);//Impresion de datos
            Console.WriteLine("Su telefono es: " + telefono);//Impresion de datos
            Console.WriteLine("Su universidad de estudio es: " + universidad);//Impresion de datos
            Console.WriteLine("Su carrera de estudio es: " + carrera);//Impresion de datos
            Console.WriteLine("Facultad a la que pertenese es: " + facultad);//Impresion de datos
            Console.WriteLine("Su ciclo de estudio es: " + ciclo_estudio);//Impresion de datos
            Console.WriteLine("************************************************************");
        }
    }
}