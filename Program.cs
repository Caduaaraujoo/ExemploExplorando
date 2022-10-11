using ExemploExplorando.Models;

Pessoa p1 = new Pessoa();
Console.WriteLine("Digite seu Nome:");
p1.Nome = Console.ReadLine();

Console.WriteLine("Digite seu Sobrenome:");
p1.Sobrenome = Console.ReadLine();

Console.WriteLine("Dgite sua Idade:");
p1.Idade = int.Parse(Console.ReadLine());

p1.Apresentar();