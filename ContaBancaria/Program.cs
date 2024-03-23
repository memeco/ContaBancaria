using System;
using SistemaContaBancaria; // Adiciona o namespace

class Program
{
    static void Main(string[] args)
    {
        // Leitura do número da conta
        Console.WriteLine("Digite o número da conta: ");
        int numeroConta = int.Parse(Console.ReadLine());

        // Leitura do nome do titular
        Console.WriteLine("Digite o nome do titular: ");
        string nomeTitular = Console.ReadLine();

        // Leitura do valor de depósito inicial (opcional)
        Console.WriteLine("Digite o valor de depósito inicial (ou 0 se não houver): ");
        double depositoInicial = double.Parse(Console.ReadLine());

        // Criação da conta bancária
        ContaBancaria conta;
        if (depositoInicial > 0)
        {
            conta = new ContaBancaria(numeroConta, nomeTitular, depositoInicial);
        }
        else
        {
            conta = new ContaBancaria(numeroConta, nomeTitular);
        }

        // Exibição dos dados da conta
        Console.WriteLine(conta);

        // Realização de um depósito
        Console.WriteLine("\nDigite o valor a depositar: ");
        double valorDeposito = double.Parse(Console.ReadLine());
        conta.Depositar(valorDeposito);

        // Exibição dos dados da conta após o depósito
        Console.WriteLine("\nApós o depósito:");
        Console.WriteLine(conta);

        // Realização de um saque
        Console.WriteLine("\nDigite o valor a sacar: ");
        double valorSaque = double.Parse(Console.ReadLine());
        bool saqueSucesso = conta.Sacar(valorSaque);

        // Exibição dos dados da conta após o saque
        Console.WriteLine("\nApós o saque:");
        if (saqueSucesso)
        {
            Console.WriteLine(conta);
        }
        else
        {
            Console.WriteLine("Saldo insuficiente para realizar o saque!");
            Console.WriteLine(conta);
        }
    }
}
