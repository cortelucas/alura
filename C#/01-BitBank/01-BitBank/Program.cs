using System;

namespace _01_BitBank
{
    class Program
    {
        static void Main(string[] args)
        {
            ContaCorrente contaGaby = new ContaCorrente();
            contaGaby.titular = "Gabriela";
            contaGaby.agencia = 098;
            contaGaby.numero = 0981;
            contaGaby.saldo = 1220.24;

            Console.WriteLine(contaGaby.titular);

            Console.ReadLine();
        }
    }
}
