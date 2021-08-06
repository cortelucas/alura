using System;

namespace _04_BitBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaLucas = new ContaCorrente();

            contaLucas.titular = "Lucas";
            contaLucas.agencia = 0938;
            contaLucas.numero = 10653;
            contaLucas.saldo += 100;

            ContaCorrente contaGaby = new ContaCorrente();
            contaGaby.titular = "Gabriela";
            contaGaby.agencia = 098;
            contaGaby.numero = 0981;
            contaGaby.saldo = 300;

            contaLucas.Sacar(50);
            Console.WriteLine(contaLucas.saldo);

            contaLucas.Depositar(500);
            Console.WriteLine(contaLucas.saldo);

            contaLucas.Transferir(200, contaGaby);

            Console.WriteLine($"Conta do Lucas: \tR$ {contaLucas.saldo}");
            Console.WriteLine($"Conta da Gaby: \t\tR$ {contaGaby.saldo}");
            Console.ReadKey();
        }
    }
}
