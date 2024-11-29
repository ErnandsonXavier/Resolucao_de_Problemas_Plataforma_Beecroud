using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Conceitos_de_C__em_pratica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Insira o nome do vendedor: ");
            string nome = Console.ReadLine();
            Console.WriteLine("Insira o salario do vendedor");
            double salario = double.Parse(Console.ReadLine());
            Console.WriteLine("Montante Total das Vendas Efetuadas");
            double Montante = double.Parse(Console.ReadLine());

            Comissao(salario, Montante);
            Console.ReadLine();
        }

        static void Comissao(double S, double C)
        {
            double Co = C  * 0.15;
            double Sa = S + Co;
            
            //Sa = Sa + C;

            Console.WriteLine($"TOTAL : {Sa:F2}");
        }

    }
}
