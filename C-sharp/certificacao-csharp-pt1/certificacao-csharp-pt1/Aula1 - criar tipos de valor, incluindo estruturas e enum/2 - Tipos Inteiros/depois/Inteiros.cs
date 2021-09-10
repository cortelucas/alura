using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro
{
    class TiposInteiros : IAulaItem
    {
        public void Executar()
        {
            int idade = 15;

            char resposta = 'S'; // System.Char, armazenado entre aspás simples.

            byte nivelDeAzul = 0xFF; //255 em decimal, não permite numeros negativos

            short passageirosVoo = 230; // System.Int16

            int populacao = 1500; // System.Int32

            long populacaoDoBrasil = 207_660_929;

            sbyte nivelDeBrilho = -127; //System.SByte
            
            ushort passageirosNavio = 230; //System.UInt16 não aceita sinal

            uint estoque = 1500; //System.UInt32 não aceita sinal, temos o ulong tbm


            Console.WriteLine($"resposta: {resposta}");

            Console.WriteLine($"nivelDeAzul: {nivelDeAzul}");
            Console.WriteLine($"passageirosVoo: {passageirosVoo}");
            Console.WriteLine($"populacao: {populacao}");
            Console.WriteLine($"populacaoDoBrasil: {populacaoDoBrasil}");

            Console.WriteLine($"niveldeBrilho: {nivelDeBrilho}");
            Console.WriteLine($"estoque: {estoque}");
            Console.WriteLine($"populacaoDoMundo: {passageirosNavio}");
        }
    }
}
