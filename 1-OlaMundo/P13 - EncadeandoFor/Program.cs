using System;
class Programa
{
    static void Main(string[] args)
    {
        Console.WriteLine("Executando Projeto 13 - Encadeando For");

        //*
        //**
        //***
        //****
        //*****

        //com break
        for (int linhas = 1; linhas <= 9; linhas++)
        {
            for (int colunas = 1; colunas <= 9; colunas++)
            {   
                Console.Write("*");
                if (colunas >= linhas)
                {
                    break;
                }

            }
            Console.WriteLine();
        }

        //sem break
        for (int linhas = 1; linhas <= 9; linhas++)
        {
            for (int colunas = 1; colunas <= linhas; colunas++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }

        Console.WriteLine("Tecle Enter para fechar ...");
        Console.ReadLine();
    }

}

