using System;
using System.Globalization;

namespace Controle_de_estoque
{
    public class Produto
    {
        public string Nome; // Variavel que contém o nome do produto
        public double Preco; // Variavel que contém o preço do produto
        public int Quantidade; // Variavel que contém a quantidade do produto

        public object Culture { get; private set; }

        // Retorna o valor total em estoque

        public double ValorTotalEmEstoque()
        {
            return Preco * Quantidade;
        }

        //Recebe a quantidade a ser adicionada ao estoque

        public void AdicionarProduto(int quantidade)
        {
            Quantidade += quantidade;
        }

        //Recebe a quantidade a ser removida do estoque

        public void RemoverProduto(int quantidade)
        {
            Quantidade = Quantidade - quantidade;
        }

        //Retorna o conteúdo do objeto em uma string

        public override string ToString()
        {
            return Nome
                + ",R$" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", "
                + Quantidade + "unidades, Total R$ " + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
