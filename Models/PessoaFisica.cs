using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp.Models
{
    public class PessoaFisica
    {
        public string NomePessoFisica { get; set; }
        public string CPFPessoaFisica { get; set; }
        public string EnderecoPessoaFisica { get; set; }  

        public void ApresentacaoPessoaFisica()
        {
            Console.WriteLine($"Eu sou {NomePessoFisica}, portador do CPF {CPFPessoaFisica}, resido {EnderecoPessoaFisica}");
        }
    }
}