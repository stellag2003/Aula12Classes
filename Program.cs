
using Aula12Classes;

Console.WriteLine("Hello, World!");

Personagem guerreiro = new Personagem();
guerreiro.nome = "Bloom";
guerreiro.raca = "Fada";
guerreiro.poder = 155;

guerreiro.mostra();

Personagem mago = new Personagem();
mago.raca = "Mago";
mago.poder = 200;
mago.nome = "Harry";

mago.mostra();

Personagem bruxa= mago;
bruxa.nome = "Gina";

bruxa.mostra();

Personagem sereia = new Personagem();
sereia.raca = "Sereia";
sereia.nome = "Ariel";
sereia.poder = 23231313;

sereia.mostra();

Console.ReadLine();

