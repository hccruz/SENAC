namespace Ex030
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = 3;

            /*
            while(num < 5)
            {
                num++;
                Console.WriteLine("Curso C#");
            }
            */

            do
            {
                num++;
                Console.WriteLine("Curso C#");
            }while (num < 5);
        }
    }
}
