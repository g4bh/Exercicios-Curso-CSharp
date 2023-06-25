namespace POOAtividadeFixacao1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            /*EXERCÍCIO 01:
            Fazer um programa para ler os dados de duas pessoas, depois mostrar o nome da pessoa mais 
            velha*/

            Pessoa Pessoa1, Pessoa2;

            Pessoa1 = new Pessoa();
            Pessoa2 = new Pessoa(); 

            Console.WriteLine("Digite o nome da primeira pessoa:");
            Pessoa1.nome = (Console.ReadLine());
            Console.WriteLine("Digite a idade da primeira pessoa:");
            Pessoa1.idade = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome da segunda pessoa:");
            Pessoa2.nome = (Console.ReadLine());
            Console.WriteLine("Digite a idade da segunda pessoa:");
            Pessoa2.idade = int.Parse(Console.ReadLine());

            if (Pessoa1.idade > Pessoa2.idade)
            {
                Console.WriteLine("A idade do(a) " + Pessoa1.nome + " é maior.");
            }
            else {
                Console.WriteLine("A idade do(a) " + Pessoa2.nome + " é maior.");
            }


            /*------------------------------------------------------*/

            /*EXERCÍCIO 02:
            Fazer um programa para ler nome e salário de dois funcionários. Depois, mostrar o salário 
            médio dos funcionários.*/

            Funcionario Func1, Func2;
            Func1 = new Funcionario();
            Func2 = new Funcionario();


            Console.WriteLine("Digite o nome do funcionário 1:");
            Func1.nome = Console.ReadLine();
            Console.WriteLine("Digite o salário do funcionário 1:");
            Func1.salario = float.Parse(Console.ReadLine());

            Console.WriteLine("Digite o nome do funcionário 2:");
            Func2.nome = Console.ReadLine();

            Console.WriteLine("Digite o salário do funcionário 2:");
            Func2.salario = float.Parse(Console.ReadLine());


            float mediaSalario = (Func1.salario + Func2.salario) / 2;

            Console.WriteLine("A média salarial dos funcionários: " + mediaSalario);
           

        }

    }
}