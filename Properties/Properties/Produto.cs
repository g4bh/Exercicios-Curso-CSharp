using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Produto
    {
        /*public string Nome;
        public double Preco;
        public int Quantidade;*/

        private string _nome;
        private double _preco;
        private int _quantidade;

        /*Uso da palavra THIS*/

        /*Referenciando outro construtor*/

        public Produto() {
            _quantidade = 0;
        }

        public Produto(string nome, double preco) : this() {
            _nome = nome;
            _preco = preco;
        }

        public Produto(string nome, double preco, int quantidade) : this(nome, preco)
        {
            _quantidade = quantidade;
        }

        /*---------------------------------*/


        /*Encapsulamento*/
        /*Uso de Get e Set:*/

        /*public string GetNome() { 
             return _nome;
        }

        public void SetNome(string nome) {
            if (nome != null & nome.Length > 1) {
                _nome = nome;
            };
        }*/

        /*------------------------------------*/


        /*Properties*/
        

        public string Nome {
            get { return _nome; }
            set {
                if (value != null & value.Length > 1)
                {
                    _nome = value;
                };
            }
        }

        public double Preco {
            get { return _preco; } 
        }

        public int Quantidade {
            get { return _quantidade; }
        }


        public double ValorTotalEmEstoque()
        {
            return _preco * _quantidade;
        }
        public void AdicionarProdutos(int quantidade)
        {
            _quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade)
        {
            _quantidade -= quantidade;
        }
        public override string ToString()
        {
            return _nome
            + ", $ "
            + _preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + _quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}
