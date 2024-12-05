using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;
using System.Runtime.InteropServices;

namespace _1012__Área
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            double a = double.Parse(Console.ReadLine());

            
            double b = double.Parse(Console.ReadLine());
            
            double c = double.Parse(Console.ReadLine());

            Triangulo(a, b );
          // Circulo();
         //   Trapezio();
          //  Quadrado();
           // Retangulo();


            Console.ReadLine();
        }

        static void Triangulo(double Base, double altura)
        {
            double Area = (Base * altura) / 2;
            Console.WriteLine($"TRIANGULO: {Area:F3}");
            //return Area;
        }

        static void Circulo(double raio)
        {
            double Area = (3.14159) * (raio * raio * raio);
            Console.WriteLine($"CIRCULO: {Area}");
        }

        static void Trapezio(double B, double b, double h)
        {
            double area = ((B + b) * h) / 2;

            Console.WriteLine($"TRAPEZIO: {area}");
        }

        static void Quadrado(double lado)
        {
            double area = lado * lado;
            Console.WriteLine($"QUADRADO: {area}");
        }

        static void Retangulo(double largura, double altura)
        {
            double area = largura * altura;

            Console.WriteLine($"RETANGULO: {area}");

        }
    }
}
