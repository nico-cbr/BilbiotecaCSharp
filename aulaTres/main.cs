using System;

class Program
{
    public static void Main(string[] args)
    {
        Random random = new Random();
        int numeroSecreto = random.Next(0, 101);
        int tentativa = 0;
        bool acertou = false;

        Console.WriteLine("Bem vindo ao jogo da adivinhação em C#!");
        // Enquanto o usuario não acertar
        while (!acertou)
        {
            Console.WriteLine("Digite sua tentativa: ");
            string input = Console.ReadLine();

            // verifica se o usuario digitou um numero
            if (int.TryParse(input, out tentativa))
            {
                // Logica do jogo
                if (tentativa < 1 || tentativa > 100)
                {
                    Console.WriteLine("Por favor digite um número entre 1 e 100!");
                }
                else if (tentativa < numeroSecreto)
                {
                    Console.WriteLine("O número secreto é maior!");
                }
                else if (tentativa > numeroSecreto)
                {
                    Console.WriteLine("o número secreto é menor!");
                }
                else
                {
                    Console.WriteLine("Párabens você acertou!");
                    acertou = true;
                }
            }
            else
            {
                Console.WriteLine("Entrada inválida. Digite outro número");
            }
        }
    }
}