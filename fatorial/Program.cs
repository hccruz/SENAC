namespace fatorial
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool mostrar = false;

            Console.Write("Digite um número inteiro: ");
            int numero = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Você quer ver os cálculos? (s/n) ");
            string resp = Console.ReadLine().ToLower();
            Console.WriteLine();

            if (resp == "s") { mostrar = true; }

            Console.WriteLine(fatorial(numero, mostrar));
        }

        static int fatorial(int n, bool show = false)
        {
            int f = 1;
            for (int i = n; i > 0; i--)
            {
                if (show)
                {
                    Console.Write(i + " ");
                    if (i > 1)
                    {
                        Console.Write("x ");
                    }
                    else
                    {
                        Console.Write("= ");
                    }
                }

                f *= i;
            }

            return f;
        }
    }
}
