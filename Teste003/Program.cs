namespace Teste003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, n3, opcao = 0;

            Console.Write("Digite o primeiro valor: ");
            n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o segundo valor: ");
            n2 = Convert.ToInt32(Console.ReadLine());

            while (opcao != 5)
            {
                Console.WriteLine();
                Console.WriteLine("Menu de opções");
                Console.WriteLine("1 - Somar");
                Console.WriteLine("2 - Subtrair");
                Console.WriteLine("3 - Multiplicar");
                Console.WriteLine("4 - Novos Números");
                Console.WriteLine("5 - Sair");
                Console.Write("Digite a opção desejada: ");
                opcao = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();

                switch (opcao)
                {
                    case 1:
                        n3 = n1 + n2;
                        Console.WriteLine("A soma dos valores é: " + n3);
                        break;
                    case 2:
                        n3 = n1 - n2;
                        Console.WriteLine("A subtração dos valores é: " + n3);
                        break;
                    case 3:
                        n3 = n1 * n2;
                        Console.WriteLine("A multiplicação dos valores é: " + n3);
                        break;
                    case 4:
                        Console.Write("Digite o primeiro valor: ");
                        n1 = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Digite o segundo valor: ");
                        n2 = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 5:
                        Console.WriteLine("Saindo...");
                        break;
                    default:
                        Console.WriteLine("Opção inválida");
                        break;
                }
            }
        }
    }
}
