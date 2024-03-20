// ATIVIDADE 2
//Escreva um programa C# que seja capaz de perguntar ao 
//usuário um operador aritmético específico (+ - * /) e com base na operação escolhida pelo usuário,
// imprima na tela a tabuada de 1 a 9 daquela operação.
//Utilize uma formatação de impressão e laço de repetição while ou for para exibir a tabuada completa dinamicamente; 

using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Digite o operador aritmético desejado (+, -, *, /):");
        char operador = Console.ReadKey().KeyChar;

        Console.WriteLine($"\nTabuada de {operador}:");
        for (int i = 1; i <= 9; i++)
        {
            for (int j = 1; j <= 9; j++)
            {
                int resultado = 0;
                switch (operador)
                {
                    case '+':
                        resultado = i + j;
                        break;
                    case '-':
                        resultado = i - j;
                        break;
                    case '*':
                        resultado = i * j;
                        break;
                    case '/':
                        if (j != 0) // Evita divisão por zero
                            resultado = i / j;
                        break;
                }
                Console.Write($"{i} {operador} {j} = {resultado}\t");
            }
            Console.WriteLine();
        }
    }
}
