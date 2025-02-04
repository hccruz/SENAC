namespace Teste002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int primeiro, razao, decimo;

            Console.Write("Digite o primeiro termo da PA: ");
            primeiro = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite a razão da PA: ");
            razao = Convert.ToInt32(Console.ReadLine());

            decimo = primeiro + (10 - 1) * razao;

            for (int i = primeiro; i <= decimo; i += razao)
            {
                Console.Write("{0}, ",i);
            }
        }
    }
}
