using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace certificacao_csharp_roteiro.antes
{
    class TiposDeValor : IAulaItem
    {
        public void Executar()
        {
            //atribuindo o valor
            //int é igual System.Int32
            int idade = 30;

            //imprimindo no console
            Console.WriteLine(idade);

            int copiaIdade = idade;
            Console.WriteLine($"idade: {idade}");
            Console.WriteLine($"copiaIdade: {copiaIdade}");


            idade = 23;
            Console.WriteLine($"idade: {idade}");
            Console.WriteLine($"copiaIdade: {copiaIdade}");

            //permite que receba int e null, mesma coisa que System.Nullable<int>
            int? idade2 = null;

        }
    }
}
