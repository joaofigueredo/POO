using System;

class Poo
{
    static void Main()
    {
        //Ola("joao", "quinta");

        Console.WriteLine("Digite os valores:");
        int valor1 = int.Parse(Console.ReadLine());
        int valor2 = int.Parse(Console.ReadLine());
        //int mult = Mult(valor1, valor2); //metodo comum
        /*
        DobrarValor(ref valor1); //passando por referencia o valor
                                 //da propria variavel muda
        Console.WriteLine(valor1);
        */
        /* metodo com dois ou mais retornos
        int resto, quociente;
        quociente = Divide(valor1, valor2, out resto);
        Console.WriteLine($"quociente = {quociente}\nresto = {resto}");
        */
        Somatorio(15,20,40,25);

    }

    static void Somatorio(params int[]n)
    {
        int res = 0;
        if(n.Length < 1)
        {
            Console.WriteLine("Nao existem valores a serem somados");
        }else if(n.Length < 2)
        {
            Console.WriteLine($"valores insuficientes apenas um: {n[0]}");
        }
        else
        {
            for(int i = 0; i < n.Length; i++)
            {
                res += n[i];

            }
            Console.WriteLine($"A soma deu {res}");
        }
        
        
    }

    static int Divide(int dividendo, int divisor, out int resto)//retornar mais de um valor
    {
        int quociente;
        resto = dividendo % divisor;

        quociente = dividendo / divisor;
        return quociente;
    }

    static void Ola(string nome, string dia)//metodo sem retorno
    {
        Console.WriteLine($"Ola {nome}, hoje é {dia}!");
    }

    static void DobrarValor(ref int valor)
    {
        valor *= 2;
    }

    static void Soma(int n1, int n2) 
    {
        int res = n1 + n2;
        Console.WriteLine($"{n1} + {n2} = {res}"); 
    }

    static int Mult(int n1, int n2) //metodo com retorno int
    {
        return n1 * n2;
    }
}