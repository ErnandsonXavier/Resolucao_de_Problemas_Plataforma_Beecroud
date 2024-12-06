using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POO_PrimeirosPassos
{
    internal class Program
    {
        enum Menu { Pessoas = 1, Funcionarios = 2, Sair = 0}

        static void Main(string[] args)
        {
            CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;
            bool escolher = false;
            while (!escolher) 
            {
                Console.WriteLine("1-Dados Pessoais\n2-Funcionarios\n0-SAIR");
                Menu opcao = (Menu)int.Parse(Console.ReadLine());
                switch (opcao)
                {
                    case Menu.Pessoas:
                        Dados_Pessoais dados1, dados2;
                         dados1 = new Dados_Pessoais();
                         dados2 = new Dados_Pessoais();


                        Console.WriteLine("Dados da primeira Pessoa:");
                        Console.WriteLine("Nome:");
                        dados1.nome = Console.ReadLine();
                        Console.WriteLine("idade:");
                        dados1.idade = int.Parse(Console.ReadLine());

                        Console.WriteLine("Dados da primeira Pessoa:");
                        Console.WriteLine("Nome:");
                        dados2.nome = Console.ReadLine();
                        Console.WriteLine("idade:");
                        dados2.idade = int.Parse(Console.ReadLine());
                        IdadePessoa(dados1.idade, dados2.idade);



                        break;
                    case Menu.Funcionarios:
                        
                        Funcionario fun1, fun2 ;
                        fun1 = new Funcionario();
                        fun2 = new Funcionario();



                        Console.WriteLine("Dados do primeiro Funcionario:");
                        Console.WriteLine("Nome:");
                        fun1.Nome = Console.ReadLine();
                        Console.WriteLine("Salario:");
                        fun1.Salario = double.Parse(Console.ReadLine());

                        Console.WriteLine("Dados do Segundo Funcionario:");
                        Console.WriteLine("Nome:");
                        fun2.Nome = Console.ReadLine();
                        Console.WriteLine("Salario:");
                        fun2.Salario = double.Parse(Console.ReadLine());

                        MediaSalario(fun1.Salario, fun2.Salario);

                        break;
                    case Menu.Sair:
                        escolher = true;
                        break;
                    default:
                        Console.WriteLine("Opcao Invalida! TENTE NOVAMENTE");
                       
                        break;
                }
            }
           
            

           
        }
        static void IdadePessoa(int idade1, int idade2)
        {
            
            if (idade1 < idade2 )
            {
                Console.WriteLine($"Pessoa Mais velha ea : {idade2}");
            }
            else
            {
                Console.WriteLine($"Pessoa Mais velha ea : {idade1}");
            }
            Console.ReadLine();
        }
        static void MediaSalario(double salario1, double salario2) 
        {
            double Media =  (salario1 * salario2)/2;
            Console.WriteLine($"A media Salarial dos Funcionarios e: {Media:F2}");
            Console.ReadLine();
          
        } 

    }
}
