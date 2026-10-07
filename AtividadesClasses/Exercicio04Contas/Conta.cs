using System;

namespace Exercicio04Contas;

public class Conta
{
    public string Titular = "";
    public string Numero = "";
    public double Saldo;

    public void Depositar(double valor)
    {
        if(valor > 0) {
        Saldo += valor;
        Console.WriteLine($"Sucesso! \n Saldo de {Titular}: {Saldo}");
        }
        else
        {
            Console.WriteLine($"Valor Inválido!");
        }
    }

    public void Sacar(double valor)
    {
        if (valor > 0) {
            if (valor < Saldo)
            {
            Saldo -= valor;
            Console.WriteLine($"Sucesso! \n Saldo de {Titular}: {Saldo}");
            } else
            {
                Console.WriteLine($"Operação recusada. \n Saldo de {Titular}: {Saldo}");
            }
    } 
        else 
        {
           Console.WriteLine("Valor Inválido"); 
        }
    }

    public void ExibirSaldo()
    {
        Console.WriteLine($"Titular: {Titular}");
        Console.WriteLine($"Número da Conta: {Numero}");
        Console.WriteLine($"Saldo Atual: {Saldo}");
    }
}  
