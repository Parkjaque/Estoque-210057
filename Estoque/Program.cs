
using System;
using System.Globalization;

namespace Controle_de_estoque
{
    class Program
    {
        static void Main(string[] args)
        {
            //Cria uma instancia de produto
            Produto p = new Produto();

            //Input do Usuário 
            Console.WriteLine("Entre com os dados do produto;");
            Console.WriteLine("Nome: ");
            p.Nome = Console.ReadLine();
            Console.Write("Preço: ");
            p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            Console.Write("Quantidade de estoque: ");
            p.Quantidade = int.Parse(Console.ReadLine());

            //Retorna o conteúdo do produto p
            Console.WriteLine("Dados dos produtos: " + p);

            //Retorna a quantidade a ser adicionada ao estoque
            Console.WriteLine("Digite o número de produtos a ser adicionado ao estoque: ");
            int qte = int.Parse(Console.ReadLine());
            p.RemoverProduto(qte);

            //Retorna o conteúdo do produto p
            Console.WriteLine("Dados do atualizados: " + p);
        }
    }
}
