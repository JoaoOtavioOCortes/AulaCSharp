﻿using AulasPOO.uteis;
int opcao = 0, num1, num2;
do
{
    Console.WriteLine("Escolha uma opção: ");
    Console.WriteLine("1 - Somar\n2 - Multiplicar\n0 - Sair");
    opcao = Convert.ToInt32(Console.ReadLine());
    switch (opcao)
    {
        case 0:
            Console.WriteLine("Você escolheu sair.");
            break;
        case 1:
            LerDoisNumerosinteiros();
            var calc = new Calculadora();
            int resultado = calc.Soma(num1, num2);
            Console.WriteLine($"O resultado é {resultado}");
            break;
        case 2:
            LerDoisNumerosinteiros();
            Console.WriteLine($"O resultado é {Calculadora.Mult(num1, num2)}");
            break;
        default:
            Console.WriteLine("Opção invalida.");
            break;
    }
} while (opcao != 0);

void LerDoisNumerosinteiros()
{
    Console.WriteLine("Digite o primeiro numero: ");
    num1 = int.Parse(Console.ReadLine());
    Console.WriteLine("Digite o segundo numero: ");
    num2 = int.Parse(Console.ReadLine());

}


/*
 * Na pasta úteis crie uma classe chamada sorteador que será capaz de sortear os nomes existentes em um vetor de nomes. A cada sorteado ele será armazenado 
 * em lista de nomes sorteados. Ao final imprimir o Lista Original e a nova Lista com os nomes sorteados
 * Crie o respectivo código de teste para a classe Sorteador
 */
