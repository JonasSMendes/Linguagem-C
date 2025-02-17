using System;
using System.Diagnostics;

class Program
{
    static void Main(string[] args)
    {
        MenuConsole();
        int menu = int.Parse(Console.ReadLine());


        while (menu != 1)
        {


            switch (menu)
            {
                case 2:
                    Soma(Valor1(), Valor2());
                    break;

                case 3:
                    Subtracao(Valor1(), Valor2());
                    break;

                case 4:
                    Mult(Valor1(), Valor2());
                    break;

                case 5:
                    Divisao(Valor1(), Valor2());
                    break;
                case 1:
                    break;

                default: Console.WriteLine("valor nao listado"); break;
            }

            MenuConsole();
            menu = int.Parse(Console.ReadLine());

        }
    }


    static void Soma(int n1, int n2)
    {
        int calc = n1 + n2;
        Console.WriteLine("a soma é de: " + calc);
    }

    static void Subtracao(int n1, int n2)
    {
        int calc = n1 - n2;
        Console.WriteLine("a subtraçao é de: " + calc);
    }

    static void Mult(int n1, int n2)
    {
        int calc = n1 * n2;
        Console.WriteLine("a subtraçao é de: " + calc);
    }

    static void Divisao(int n1, int n2)
    {
        int calc = n1 / n2;
        Console.WriteLine("a subtraçao é de: " + calc);
    }


    static int Valor1()
    {
        Console.WriteLine("digite o primeiro valor");
        int n1 = int.Parse(Console.ReadLine());
        return n1;
    }

    static int Valor2()
    {
        Console.WriteLine("digite o segundo valor");
        int n2 = int.Parse(Console.ReadLine());
        return n2;
    }

    static void MenuConsole()
    {
        Console.WriteLine("""
        ################################################## 

        Tipos de calculo disponivel, escolha um numero: 

        2 - soma
        3 - subtraçao
        4 - multiplicaçao
        5 - divisão
        1 - Sair

        ###################################################
        """);
    }
}
