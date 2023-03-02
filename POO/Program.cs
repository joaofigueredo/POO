using System;

class Poo
{
    static void Main()
    {
        //Ola("joao", "quinta");

        Console.WriteLine("Digite os valores:");
        int valor1 = int.Parse(Console.ReadLine());
        int valor2 = int.Parse(Console.ReadLine());
        //int mult = Mult(valor1, valor2);
        Console.WriteLine(Mult(valor1, valor2));

    }

    static void Ola(string nome, string dia)
    {
        Console.WriteLine($"Ola {nome}, hoje é {dia}!");
    }

    static void Soma(int n1, int n2) 
    {
        int res = n1 + n2;
        Console.WriteLine($"{n1} + {n2} = {res}"); 
    }

    static int Mult(int n1, int n2)
    {
        return n1 * n2;
    }
}