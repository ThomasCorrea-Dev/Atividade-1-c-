//ATIVIDADE 6
double salar = 0;
double aument = 0;
double salarfinal = 0;

Console.Write("Qual o seu salário: ");
salar = Convert.ToDouble(Console.ReadLine());

Console.Write("Qual o aumento salarial parcealmente: ");
aument = Convert.ToDouble(Console.ReadLine());

salarfinal = salar * (aument / 100) + salar;

Console.Write($"\n O seu novo slário será de: R${salarfinal}.");