using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp.Models
{
    public class Escrever
    {
        public string Caneta { get; set; }
        public string Mensagem { get; set; }

        public void EnviarMensagem()
        {
            Console.WriteLine($"Sou Optimus Prime e estou usando uma {Caneta} deixando aqui essa mensagem: \n\n\t\t {Mensagem}\n\n");
            Console.WriteLine("--------------------------------------------------");
        }
    }
}