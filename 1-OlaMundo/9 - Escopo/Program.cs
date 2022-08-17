using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando Projeto 9 - Escopo");

        int idadeJoao = 16;

        bool grupo = true;

        string textoAdicional;

        if (grupo)
        {
            textoAdicional = "João está acompanhado";
        }
        else
        {
            textoAdicional = "Não está em grupo";
        }

        if (idadeJoao >= 18 || grupo)
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Pode Entrar");
        }
        else
        {
            Console.WriteLine(textoAdicional);
            Console.WriteLine("Não entra");
        }

        Console.WriteLine("Tecle Enter para fechar ...");
        Console.ReadLine();
    }

}

