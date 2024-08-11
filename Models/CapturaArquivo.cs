using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace csharp.Models
{
    public class CapturaArquivo
    {
        public string DiretorioEntrada { get; set; }    
        public string ArquivoEntrada { get; set; }

        public void DiretorioArquivoEntrada()
        {
            Console.WriteLine($"O diretório de entrada é: {DiretorioEntrada} e o arquivo é {ArquivoEntrada}.");
        }
    }
}