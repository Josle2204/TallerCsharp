using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerCsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //--Escribir mensaje--
            Console.WriteLine("Bienvenido a C#");
            Console.WriteLine("WAZA2");

            //--Definir variables--
            int a, b, producto;

            //--Entrada de Datos--

            Console.WriteLine("Ingrese Primer Numero:");
            //Guardar valor e la consola
            a= int.Parse(Console.ReadLine());
            //Valida si es número sí o sí
            //a= int.TryParse(Console.ReadLine());  //Boolean True o Flase

            Console.WriteLine("Ingrese Segundo Numero:");
            //Guardar valor e la consola
            b = Convert.ToInt32(Console.ReadLine());
            //Covnierte cualquier valor a numero
            //b= int.TryParse(Console.ReadLine());  //Boolean True o Flase

            //--Proceso--
            producto = a * b;

            //--Salida Datos--
            Console.WriteLine("El producto es: " + (producto+2));
            Console.WriteLine($"El producto de {a} * {b} = {producto+2}");


            Console.WriteLine(); //Salto de Linea
            Console.WriteLine("Algoritmo area triangulo:");

            ejercicio1 ej1 = new ejercicio1();
            ej1.areatriangulo();
            //Detener pantalla para mostrar el resultado
            Console.ReadKey();
        }
    }
}
