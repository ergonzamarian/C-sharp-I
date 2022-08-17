using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando Projeto 8 - Condicionais2");

        int idadeJoao = 16;

        bool grupo = false;

        if (idadeJoao >= 18 || grupo)
        {
            Console.WriteLine("Pode Entrar");
        }
        else
        {
            Console.WriteLine("Não entra");
        }

        Console.WriteLine("Tecle Enter para fechar ...");
        Console.ReadLine();
    }

}

