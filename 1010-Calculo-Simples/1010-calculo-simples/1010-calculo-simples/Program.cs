using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Globalization;

namespace _1010_Calculo_Simples
{
    internal class Program
    {

        static void Main(string[] args)
        {
            // Configurar o separador decimal como ponto
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

            float totalFinal = 0; // Variável para armazenar o total a ser pago

            // Loop para processar as 2 peças
            for (int i = 1; i <= 2; i++)
            {
                Console.WriteLine($"Digite os dados da peça {i} no formato: código quantidade valor (Ex: 12 1 5.30):");

                // Ler os dados em uma única linha
                string[] dados = Console.ReadLine().Split(' ');

                // Converter os dados para os tipos corretos
                int codigo = int.Parse(dados[0]);           // Código da peça (não será usado no cálculo)
                int quantidade = int.Parse(dados[1]);       // Quantidade de peças
                float valorUnitario = float.Parse(dados[2]); // Valor unitário da peça

                // Calcular o custo total da peça usando a função Calculo
                float totalPeca = Calculo(quantidade, valorUnitario);

                // Somar o valor da peça ao total final
                totalFinal += totalPeca;
            }

            // Exibir o valor total com 2 casas decimais
            Console.WriteLine($"VALOR A PAGAR: R$ {totalFinal:F2}");
            Console.ReadLine();
        }

        static float Calculo(int NumPecas, float ValorPecas)
        {
           
            float total = ValorPecas * NumPecas;
            return total;
        }

    }
}