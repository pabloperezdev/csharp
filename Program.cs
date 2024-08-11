using csharp;
using csharp.Models;

internal class Program
{
    private static void Main(string[] args)
    {
        Pessoa P = new Pessoa();
        P.Nome = "Pablo";
        P.Idade = 37;
        P.Apresentar();


        Bebe b = new Bebe();
        b.Nenem = "Mell";
        b.Idade = 3;
        b.TrocarFralda();



        Escrever mensagem = new Escrever();
        mensagem.Caneta = "BIC";
        mensagem.Mensagem = "Vem comigo que vc passa de ano ";
        mensagem.EnviarMensagem();

        PessoaFisica PFisica = new PessoaFisica();
        PFisica.NomePessoFisica = "Pablo Perez";
        PFisica.CPFPessoaFisica = "364.905.628-XX";
        PFisica.EnderecoPessoaFisica = "Av Paraibuna, 44 CEP: 09930-560 | Campanário - Diadema - SP";
        PFisica.ApresentacaoPessoaFisica();

        CapturaArquivo capturaArquivo = new CapturaArquivo();
        capturaArquivo.DiretorioEntrada = "c:\\Download\\";
        capturaArquivo.ArquivoEntrada = "CurriculoPablo.txt";
        capturaArquivo.DiretorioArquivoEntrada();
    }
}
