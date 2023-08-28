using System.Numerics;

namespace Vetores
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Digite a quantidade de produtos:");
            int n = int.Parse(Console.ReadLine());
                
            Produto[] produtos = new Produto[n];

            for (int i = 0; i < n; i++) {
                Console.WriteLine("Digite o nome do produto:");
                string name = Console.ReadLine();
                Console.WriteLine("Digite o preço do produto:");
                double valor = double.Parse(Console.ReadLine());
                produtos[i] = new Produto { Name = name, Price = valor };
            }

            double sum = 0;

            for (int i = 0; i < n; i++) {
                sum += produtos[i].Price;
            }

            double avg = sum / n;

            Console.WriteLine("AVEREGE PRICE = " + avg.ToString());
        }
    }
}