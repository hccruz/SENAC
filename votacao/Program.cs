namespace votacao
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Em qual ano você nasceu? ");
            int nasc = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();

            Console.WriteLine(voto(nasc));
        }

        static string voto(int ano)
        {
            DateTime dataAtual = DateTime.Now;
            int anoAtual = dataAtual.Year;
            int idade = anoAtual - ano;
            if (idade < 16) 
            {
                return $"Com {idade} anos: você não vota.";
            }
            else if (idade >= 18 && idade < 70)
            {
                return $"Com {idade} anos: você vota.";
            }
            else
            {
                return $"Com {idade} anos: seu voto é opcional.";
            }
        }
    }
}
