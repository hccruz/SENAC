namespace metodos
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Saudacao("Heraldo"); // Olá Heraldo, seja bem-vindo!
            Soma(10, 20);
        }

        // Método Saudacao
        static void Saudacao(string nome)
        {
            // Exibe uma mensagem de saudação
            Console.WriteLine($"Olá {nome}, seja bem-vindo!"); // Olá Heraldo, seja bem-vindo!
        }

        static void Soma(int a, int b)
        {
            int resultado = a + b;
            Console.WriteLine($"A soma de {a} + {b} é igual a {resultado}.");
            Console.WriteLine("A soma de {0} + {1} é igual a {2}.", a, b, resultado);
            Console.WriteLine("A soma de " + a + " + " + b + " é igual a " + resultado + ".");
        }
    }
}
