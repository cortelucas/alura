using System;

namespace _05_BitBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente conta = new();

            conta.titular = new Cliente();
            conta.titular.nome = "Lucas";
            conta.titular.profissao = "Desenvolvedor";
            conta.titular.cpf = "411.9371.28-85";
            conta.agencia = 0938;
            conta.numero = 1065319;

            Console.WriteLine(conta.titular);

            Console.ReadLine();
        }
    }
}
