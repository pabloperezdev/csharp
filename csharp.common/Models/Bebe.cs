using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp.common.Models
{
    public class Bebe
    {
        public string Nenem { get; set; }   
        public int Idade { get; set; }
        
        public void TrocarFralda()
        {
            Console.WriteLine($"\nA {Nenem} de {Idade} precisa trocar a fralda\n");
            Console.WriteLine("--------------------------------------------------");
        }
    }
}