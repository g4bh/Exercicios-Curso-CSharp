namespace ExercicioPoo_Estoque
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Produto p = new Produto();
            int opcao;

            do
            {
                Console.WriteLine("Escolha uma opção:\n1 - Entrar com os dados do produto \n2 - Adicionar produtos \n3 - Remover produtos\n4 - Sair\n");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao) 
                {
                    case 1:
                        Console.WriteLine("\nEntre os dados dos produtos: ");
                        Console.Write("Nome: ");
                        p.Nome = Console.ReadLine();

                        Console.Write("Preço: ");
                        p.Preco = double.Parse(Console.ReadLine());

                        Console.Write("Quantidade no estoque: ");
                        p.Quantidade = int.Parse(Console.ReadLine());

                        Console.WriteLine("\nDados dos produtos: " + p);
                        break;
                        
                    case 2:
                        Console.Write("\nDigite o número de produtos que deseja adicionar:");
                        int qte = int.Parse(Console.ReadLine());
                        p.AdicionarQuantidade(qte);
                        Console.WriteLine("\nDados atualizados: " + p);
                        break;

                    case 3:
                        Console.Write("\nDigite o número de produtos que deseja excluir:");
                        int qtExcluir = int.Parse(Console.ReadLine());
                        p.RemoverQuantidade(qtExcluir);
                        Console.WriteLine("Dados atualizados: " + p);
                        break;

                    case 4:
                        Console.WriteLine("\nPROGRAMA ENCERRADO!");
                        break;

                    default:
                        Console.WriteLine("Opção inálida! Tente novamente!\n");
                        break;
                };
            } while (opcao != 4);
        }
    }
}