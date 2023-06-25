using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExercicioPoo_Estoque
{
    internal class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;


        public double valorTotalEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarQuantidade(int quantidade) {
            Quantidade += quantidade;
        }


        public void RemoverQuantidade(int quantidade) { 
            Quantidade -= quantidade;
        }

        public override string ToString()
        {
            return Nome + ", R$" + Preco.ToString("F2", CultureInfo.InvariantCulture) + ", " + Quantidade 
            + " unidades \nTOTAL: R$ " + valorTotalEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
