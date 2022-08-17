using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando Projeto 12 - Investindo a longo Prazo");

        double fatorRendimento = 1.005;
        double investimento = 1000;

        for (int ano = 1; ano <= 5; ano++)
        {
            for (int mes = 1; mes <= 12; mes++)
            {
                investimento *= fatorRendimento;
            }
            fatorRendimento = fatorRendimento + 0.001;
        }
        Console.WriteLine("Depois de 5 anos você terá " + investimento);

        Console.WriteLine("Tecle Enter para fechar ...");
        Console.ReadLine();
    }

}

