using System;
class Program
{
    public static void Main(string[] args)
    {
        // criando variaveis
        float altura = 0;
        float largura = 0;

        // pegando valorres
        Console.WriteLine("Calculadora de areade retangulo");

        Console.WriteLine("Digite a altura:");
        string alturaS = Console.ReadLine();

        Console.WriteLine("Digite a largura:");
        string larguraS = Console.ReadLine();

        // string to float
        float.TryParse(alturaS, out altura);
        float.TryParse(larguraS, out largura);


        // fazendo resultados
        float resultado = altura * largura;
        Console.WriteLine("A área do retangulo é: " + resultado);
    }
}