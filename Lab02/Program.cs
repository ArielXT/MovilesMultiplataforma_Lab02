using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1;
            int y1;
            int x2;
            int y2;
            int x3;
            int y3;
            int x4;
            int y4;
            double punto1;
            double punto2;
            double punto3;
            double punto4;
            double perimetro;
            double suma_de_areas;
            double area;
            Console.WriteLine("Ingrese Los Valores X y Y del primer punto:");
            x1 = int.Parse(Console.ReadLine());
            y1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Los Valores X y Y del Segundo punto:");
            x2 = int.Parse(Console.ReadLine());
            y2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Los Valores X y Y del Tercer punto:");
            x3 = int.Parse(Console.ReadLine());
            y3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese Los Valores X y Y del Cuarto punto:");
            x4 = int.Parse(Console.ReadLine());
            y4 = int.Parse(Console.ReadLine());
            punto1 = Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2));
            punto2 = Math.Sqrt(Math.Pow(x2 - x3, 2) + Math.Pow(y2 - y3, 2));
            punto3 = Math.Sqrt(Math.Pow(x3 - x4, 2) + Math.Pow(y3 - y4, 2));
            punto4 = Math.Sqrt(Math.Pow(x4 - x1, 2) + Math.Pow(y4 - y1, 2));
            perimetro = punto1 + punto2 + punto3 + punto4;
            suma_de_areas = Math.Abs((x1 * y2 + x2 * y3 + x3 * y4 + x4 * y1) - (x1 * y4 + x4 * y3 + x3 * y2 + x2 * y1));
            area = suma_de_areas / 2;
            Console.WriteLine("------------------------------------------------------------------------");
            Console.WriteLine("El Perimetro del Rectangulo es: " + perimetro + " y su Area es: " + area);
            Console.WriteLine("------------------------------------------------------------------------");
            Console.Read();
        }
    }
}
