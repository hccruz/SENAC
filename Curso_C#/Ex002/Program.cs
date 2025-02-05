namespace Ex002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numero = -45;
            float num = 4.58f;
            char letra = 'c';
            string nome = "Heraldo";

            Console.WriteLine("O número é {0}.", numero);
            Console.WriteLine("O valor é R${0}.", num);
            Console.WriteLine("A letra é {0}.", letra);
            Console.WriteLine("Seu nome é {0}.", nome);

            Console.WriteLine("O número é {0}, o valor é R${1}, a letra e {2} e seu nome é {3}.", numero, num, letra, nome);
        }
    }
}
