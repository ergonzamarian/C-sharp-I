using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando Projeto 7 - Condicionais");

        int idadeJoao = 18;
        int quantidadePessoas = 2;

        if (idadeJoao >= 18)
        {
            Console.WriteLine("Pode Entrar");
        }
        else
        {
            if (quantidadePessoas >= 0)
            {
                Console.WriteLine("Ele está acompanhado, pode entrar!");
            }
            else
            {
                Console.WriteLine("Não pode entrar!");
            }
            Console.WriteLine("Não entra");
        }

        Console.WriteLine("Tecle Enter para fechar ...");
        Console.ReadLine();
    }

}

