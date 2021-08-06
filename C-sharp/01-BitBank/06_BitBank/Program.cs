using System;

namespace _06_BitBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new();
            Cliente cliente = new();

            cliente.Nome = "Lucas";
            cliente.CPF = "411.937.728-85";
            cliente.Profissao = "Desenvolvedor";

            conta.Titular = cliente;
            conta.Saldo = -10;

            Console.WriteLine(conta.Titular.Nome);
            Console.WriteLine(conta.Saldo);
            Console.ReadLine();
        }
    }
}
