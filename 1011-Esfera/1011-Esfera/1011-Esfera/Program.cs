using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1011_Esfera
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            //Console.ReadLine();
            double raio = double.Parse(Console.ReadLine());

            // Corrigir a divisão para garantir que seja feita como operação de ponto flutuante
            double formula1 = 4.0 / 3.0; // Agora é uma divisão de ponto flutuante
            double formula2 = raio * raio * raio;
            double pi = 3.14159;

            double formula = formula1 * pi * formula2;

            // Exibir o resultado com 2 casas decimais
            Console.WriteLine($"VOLUME = {formula:F2}");

            Console.ReadLine();


            /* outra forma mais tecnica
             
             using System;

class Program
{
    static void Main(string[] args)
    {
        // Ler o valor do raio
        Console.WriteLine("Digite o valor do raio da esfera: ");
        double raio = double.Parse(Console.ReadLine());

        // Calcular o volume da esfera utilizando a fórmula V = (4/3) * π * r³
        double volume = (4.0 / 3.0) * Math.PI * Math.Pow(raio, 3);

        // Exibir o resultado com 2 casas decimais
        Console.WriteLine($"O volume da esfera é: {volume:F2} unidades cúbicas");
    }
}
             
             */
        }
    }
}
