namespace PalpitesMegaSena
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            List<int> lista = [];
            List<List<int>> jogos = [];

            Console.Write("Quantos jogos você quer que eu sorteie? ");
            int quant = Convert.ToInt32(Console.ReadLine());
            int tot = 1;
            while (tot <= quant)
            {
                int cont = 0;
                while (true)
                {
                    int num = random.Next(1, 60);
                    if (!lista.Contains(num))
                    {
                        lista.Add(num);
                        cont++;
                    }
                    if (cont >= 6) { break; }
                }
                lista.Sort();
                jogos.Add(lista);
                lista.Clear();
                tot++;
            }

            Console.WriteLine($"Sorteando {quant} jogos.");

            foreach (List<int> jogo in jogos)
            {
                Console.WriteLine(string.Join(", ", jogo));
            }

        }
    }
}
