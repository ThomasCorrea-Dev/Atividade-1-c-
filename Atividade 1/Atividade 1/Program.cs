//ATIVIDADE 1
string nome;
string sobrenome;
string programas;

Console.Write("Qual o seu nome: ");
nome = Console.ReadLine();

Console.Write("Qual o seu sobrenome: ");
sobrenome = Console.ReadLine();

Console.Write("Quais áreas da programação que você mais se interessa: ");
programas = Console.ReadLine();

Console.WriteLine($"\nO seu nome é {nome} {sobrenome} e a área de programação em que você mais se interessa é {programas}.");
