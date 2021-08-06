using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_BitBank
{
    class ContaCorrente
    {
        public Cliente titular; 
        public int agencia;
        public int numero;
        public double saldo;

        public bool Sacar(double valor)
        {
            if (this.saldo < valor)
            {
                return false;
            }
            this.saldo -= valor;
            return true;
        }

        public void Depositar(double valor) //void não tem retorno
        {
            this.saldo += valor;
        }

        public bool Transferir(double valor, ContaCorrente contaDestino)
        {
            if (this.saldo < valor)
            {
                return false;
            }

            this.saldo -= valor;
            Depositar(valor);
            return true;
        }
    }
}
