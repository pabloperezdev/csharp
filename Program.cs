using csharp.Models;

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