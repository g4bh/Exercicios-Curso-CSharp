using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consstrutores
{
    internal class Produto
    {
            public string Nome;
            public double Preco;
            public int Quantidade;
            
            /*Exemplo de sobrecarga*/
            public Produto(string nome, double preco, int quantidade) {
                Nome = nome;
                Preco = preco;
                Quantidade = quantidade;
            }    
            /*----------*/

            public double ValorTotalEmEstoque()
            {
                return Preco * Quantidade;
            }
            public void AdicionarProdutos(int quantidade)
            {
                Quantidade += quantidade;
            }
            public void RemoverProdutos(int quantidade)
            {
                Quantidade -= quantidade;
            }
            public override string ToString()
            {
                return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
            }
    }
}
