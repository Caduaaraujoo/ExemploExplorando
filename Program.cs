using ExemploExplorando.Models;

Pessoa p1 = new Pessoa(nome: "Cadu", sobrenome: "Araujo");
Pessoa p2 = new Pessoa(nome: "Eduardo", sobrenome: "Araujo");

Curso CursoDeIngles = new Curso();
CursoDeIngles.Nome = "Ingles";
CursoDeIngles.Alunos = new List<Pessoa>();

CursoDeIngles.AdicionarAluno(p1);
CursoDeIngles.AdicionarAluno(p2);

Console.WriteLine(CursoDeIngles.ObterQuantidadeDeAlunosMatriculados());
CursoDeIngles.ListarAlunos();
















// Pessoa p1 = new Pessoa();
// Console.WriteLine("Digite seu Nome:");
// p1.Nome = Console.ReadLine();

// Console.WriteLine("Digite seu Sobrenome:");
// p1.Sobrenome = Console.ReadLine();

// Console.WriteLine("Dgite sua Idade:");
// p1.Idade = int.Parse(Console.ReadLine());

// p1.Apresentar();