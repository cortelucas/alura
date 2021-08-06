using System;

namespace _03_BitBank
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

            ContaCorrente contaDaGabrielaCosta = new ContaCorrente();
            contaDaGabrielaCosta.titular = "Gabriela";
            contaDaGabrielaCosta.agencia = 863;
            contaDaGabrielaCosta.numero = 863452;

            Console.WriteLine(contaGaby == contaDaGabrielaCosta); //false
            Console.WriteLine(contaGaby.titular);

            Console.ReadLine();
        }
    }
}
