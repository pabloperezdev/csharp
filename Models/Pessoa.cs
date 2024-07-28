using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp.Models
{
    public class Pessoa
    {
        public string Nome { get; set; }
        public int Idade { get; set; }  

        public void Apresentar()
        {
            Console.WriteLine($"Olá,meu nome é: {Nome}, \n\t\ttenho {Idade} anos\n");
            Console.WriteLine("--------------------------------------------------");
        }
    }
}
