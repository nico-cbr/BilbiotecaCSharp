using System;

class Program
{
    public static void Main(string[] args)
    {
        string siga = "vermelho";

        if (siga == "verde")
        {
            Console.WriteLine("AVANÇE");
        }
        else if (siga == "vermelho")
        {
            Console.WriteLine("PARE");
        }
        else if (siga == "amarelo")
        {
            Console.WriteLine("ATENÇÃO");
        }
        else
        {
            Console.WriteLine("O semáforo parou!");
        }
    }
}