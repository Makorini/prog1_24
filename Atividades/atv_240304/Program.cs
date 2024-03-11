//1)Após sincronizada a sua branch main, tire uma nova branch
//para o exercicio;
//2) Crie um novo projeto na pasta atividades com o nome
//Atividade_240304
//3) Crie um programa em C# que seja capaz de realizar as 4
//operações aritiméticas básicas:
//a) Leia o primeiro operando;
//b) Leia o Operador aritmético;
//c) Leia o segundo número;
//Ideinfique qual operação foi solicitado pelo usuário, permitindo trabalhar com números reais e inteiros, processe e exiba o resultado;|
﻿Console.Clear();
// Declaração e inicialização das variáveis a serem utilizadas
double primeiroValor = 0d;
double segundoValor = 0d;
double resultado = 0d;
int opcao = 0;

// Escrita do primeiro valor e conversão para double
Console.WriteLine("--------------- CALCULADORA ---------------");
Console.Write("Para começar, informe o primeiro número: ");
primeiroValor = Convert.ToDouble(Console.ReadLine());
Console.Clear();

// Escrita da variável que recebe a opção, e conversão para int de modo a ser utilizado no Switch Case
Console.WriteLine("--------------- CALCULADORA ---------------");
Console.WriteLine("Agora, informe a operação a ser realizada. ");
Console.WriteLine("1 - Adição\n2 - Subtração\n3 - Multiplicação\n4 - Divisão");
opcao = Convert.ToInt32(Console.ReadLine());
Console.Clear();

// Escrita do segundo valor e conversão para double
Console.WriteLine("--------------- CALCULADORA ---------------");
Console.Write("Por último, informe o segundo número: ");
segundoValor = Convert.ToDouble(Console.ReadLine());
Console.Clear();

// Verificação da operação no console.
Console.Write($"A operação realizada será {primeiroValor}"+(opcao==1 ? " + " : opcao==2? " - ": opcao==3? " x ": " / ")+$"{segundoValor}");
Thread.Sleep(3000);
Console.Clear();

// Efetuação da operação e escritura na variável de resultado
switch(opcao){
    case 1:
        resultado = primeiroValor+segundoValor;
        break;
    case 2:
        resultado = primeiroValor-segundoValor;
        break;
    case 3:
        resultado = primeiroValor*segundoValor;
        break;
    case 4:
        resultado = primeiroValor/segundoValor;
        break;
    default:
        Console.WriteLine("Opção inválida. Por favor, tente novamente.");
        Thread.Sleep(3000);
        break;
}

// Apresentação do resultado ao usuário
Console.Write($"O resultado final é: {resultado}");