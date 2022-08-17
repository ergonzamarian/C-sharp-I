using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando Projeto 11 - Calcula Poupança2");

        double investimento = 1000.0;

        //rendimento de 0.5% (0.005) ao mês
        for (int mes = 1; mes <= 12; mes++)
        {
            investimento *= 1.005;
            Console.WriteLine("No mês " + mes + " você tem " + investimento);
        }



        Console.WriteLine("Tecle Enter para fechar ...");
        Console.ReadLine();
    }

}

