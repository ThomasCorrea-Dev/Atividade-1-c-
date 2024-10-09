//ATIVIDADE 5
double decimais = 0;
int inteiros = 0;

Console.Write(" Qual o seu número decimal:");
decimais = Convert.ToDouble(Console.ReadLine());

inteiros = (int)(decimais * 10);
Console.WriteLine($"\n O seu número decimal inserido convertido para um número inteiro é: {inteiros}");