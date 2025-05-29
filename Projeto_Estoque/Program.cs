using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projeto_Estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Olá, bem vindo!");
            Console.WriteLine("Entre com os dados do produto");
            Console.Write("Nome: ");
            string nome = Console.ReadLine();
            Console.Write("Preço: ");
            double preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade em Estoque: ");
            int quantidade = int.Parse(Console.ReadLine());

            Produto p = new Produto(nome, preco, quantidade);

            Console.WriteLine();
            Console.WriteLine("Dados do Produto: " + p);

            Console.Write("Você deseja adicionar ou remover produtos? (escreva adicionar ou remover): ");
            string resp = Console.ReadLine();

            if (resp == "adicionar")
            {
                Console.WriteLine();
                Console.Write("Digite o número de produtos para adicionar ao estoque: ");
                int qte = int.Parse(Console.ReadLine());
                p.AdicionarProdutos(qte);
                Console.WriteLine();
                Console.WriteLine("Dados Atualizados: " + p);
            }
            else if (resp == "remover")
            {
                Console.WriteLine();
                Console.Write("Digite o número de produtos para remover do estoque: ");
                int qte = int.Parse(Console.ReadLine());
                p.RemoverProdutos(qte);
                Console.WriteLine();
                Console.WriteLine("Dados Atualizados: " + p);
            }
            else
            {
                return;
            }
        }
    }
}
