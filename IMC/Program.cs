namespace IMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite o seu peso (kg): ");
            double peso = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Digite a sua altura (m): ");
            double altura = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();

            double imc = peso / (altura * altura);

            if (imc < 18.5)
            {
                Console.WriteLine($"Você está ABAIXO do peso normal. IMC = {imc:F2}");
            }
            else if (imc < 25)
            {
                Console.WriteLine($"Você está no peso NORMAL. IMC = {imc:F2}");
            }
            else if (imc < 30)
            {
                Console.WriteLine($"Você está em SOBREPESO. IMC = {imc:F2}");
            }
            else if (imc < 40)
            {
                Console.WriteLine($"Você está em OBESIDADE. IMC = {imc:F2}");
            }
            else
            {
                Console.WriteLine($"Você está em OBESIDADE MÓRBIDA. IMC = {imc:F2}");
            }
        }
    }
}
