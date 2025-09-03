using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerCsharp
{
    public class ejercicio1
    {
        public void areatriangulo() {

            //Definir variables
            //float s, area;

            //Solicitar datos
            Console.WriteLine("Ingrese lado a: ");
            //Guardar datos
            var a= int.Parse(Console.ReadLine());

            //Solicitar datos
            Console.WriteLine("Ingrese lado b: ");
            //Guardar datos
            var b = int.Parse(Console.ReadLine());

            //Solicitar datos
            Console.WriteLine("Ingrese lado c: ");
            //Guardar datos
            var c = int.Parse(Console.ReadLine());

            //Proceso
            var s = (a + b + c) / 2;
            var area = Math.Sqrt(s * (s - a) * (s - b) * (s - c));

            //Salida datos
            Console.WriteLine($"El area del triangulo es según los lados {a}, {b}, {c} es: {area}m2");

            //Detener pantalla de resultados
            Console.ReadKey();

        }
    }
}
