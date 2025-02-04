namespace Teste001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, t1 = 0, t2 = 1, cont = 3;

            Console.Write("Digite o número de termos: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("{0}, {1}, ", t1, t2);

            while (cont <= n)
            {
                int t3 = t1 + t2;
                Console.Write("{0}, ", t3);
                t1 = t2;
                t2 = t3;
                cont++;
            }
        }
    }
}
