namespace TesteSenha
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string senha = "123";  // Senha correta
            string senhaDigitada;  // Senha digitada pelo usuário
            int tentativas = 0;  // Contador de tentativas

            // Loop para solicitar a senha até que o usuário acerte ou exceda o número de tentativas
            do
            {
                Console.Clear(); // Limpa a tela
                Console.Write("Digite a senha: ");
                senhaDigitada = Console.ReadLine();
                tentativas++;  // Incrementa o contador de tentativas
                if (senhaDigitada != senha && tentativas < 3)  // Se a senha estiver incorreta e o número de tentativas for menor que 3
                {
                    Console.WriteLine("Senha incorreta! - Tentativas: " + tentativas);
                    Console.WriteLine("Você tem ainda " + (3 - tentativas) + " tentativa(s).");
                    Console.ReadKey();
                }
                else if (senhaDigitada != senha && tentativas == 3) // Se a senha estiver incorreta e o número de tentativas for igual a 3
                {
                    Console.Clear();
                    Console.WriteLine("Senha incorreta! - Tentativas: " + tentativas);
                    Console.WriteLine("Você excedeu o número de tentativas permitidas.");
                    return;
                }
            } while (senhaDigitada != senha);

            // Se a senha estiver correta
            Console.Clear();
            Console.WriteLine("Senha correta! - Tentativas: " + tentativas);
            
        }
    }
}
