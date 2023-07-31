using System.Globalization;

namespace AtividadeFixacao_Secao5_Banco
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Banco b;

            Console.Write("Entre o número da conta: ");
            int numero = int.Parse(Console.ReadLine());
            Console.Write("Entre o titular da conta: ");
            string titular = Console.ReadLine();
            
            Console.Write("Haverá depósito inicial? (s/n) ");
            char condicao = char.Parse(Console.ReadLine());
            if (condicao == 's' || condicao == 'S')
            {
                Console.WriteLine("");
                Console.Write("Entre com o valor do deposito:");
                double depositoInicial = double.Parse(Console.ReadLine());
                b = new Banco(numero, titular, depositoInicial);
            }
            else { 
                b = new Banco(numero, titular);
            }

            Console.WriteLine("Dados da conta: " + b);


            Console.WriteLine("");
            Console.Write("Entre um valor para depósito: ");
            double valor = double.Parse(Console.ReadLine());
            b.DepositoConta(valor);

            Console.WriteLine("Dados da conta: " + b);



            Console.WriteLine("");
            Console.Write("Entre um valor para saque: ");
            valor = double.Parse(Console.ReadLine());
            b.SaqueConta(valor);

            Console.WriteLine("Dados da conta: " + b);
        }
    }
}
