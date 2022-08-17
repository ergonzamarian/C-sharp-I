using System;
class Programa
{
    static void Main(string[] args)
    {
        double salario = 3000.15;

        //32 bits
        int salarioInteiro = (int) salario;
        salarioInteiro = 200000000;

        //64 bits
        long salarioLong = 20000000000000000;

        //16 bits
        short salarioShort = 20000;


        float salarioFloat = 1.80f; 

        Console.WriteLine("Tecle Enter para fechar ...");
        Console.ReadLine();
    }

}

