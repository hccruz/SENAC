namespace Vetor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            int[] n = new int[5];

            n[0] = 10;
            n[1] = 20;
            n[2] = 30;
            n[3] = 40;
            n[4] = 50;

            Console.WriteLine(n[3]);

            int[] num = new int[5] { 50, 60, 70, 80, 90 };

            Console.WriteLine(num[1]);

            int[] numeros = new int[10];

            Random random = new Random();

            for (int i = 0; i < 10; i++)
            {
                numeros[i] = random.Next(0, 100);
                Console.WriteLine(numeros[i]);
            }

            double[] reais = new double[5];

            for (int i = 0; i < 5; i++)
            {
                reais[i] = random.NextDouble() * 10000;
            }

            Console.WriteLine();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(reais[i].ToString("N2"));
            }
            */

            string[] nomes = { "Maria", "João", "José", "Pedro", "Ana" };

            for (int i = 0; i < nomes.Length; i++)
            {
                if (i < nomes.Length - 1)
                {
                    Console.Write(nomes[i] + ", ");
                }
                else
                {
                    Console.Write(nomes[i] + ".");
                }

            }

        }
    }
}
