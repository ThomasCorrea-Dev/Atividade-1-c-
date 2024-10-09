//ATIVIDADE 7
int nota1, nota2, nota3 = 0;
double soma = 0;
double media = 0;

Console.Write("Qual a sua primeira nota: ");
nota1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Qual a sua primeira nota: ");
nota2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Qual a sua primeira nota: ");
nota3 = Convert.ToInt32(Console.ReadLine());

soma = nota1 + nota2 + nota3;
media = soma / 3;

Console.WriteLine($"\n A sua nota final é: {media}.");