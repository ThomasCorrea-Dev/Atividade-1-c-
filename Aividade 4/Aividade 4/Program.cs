//ATIVIDADE 4
double Raio;
double valordepi = 3.14;
double valordaarea = 0;

Console.Write("Informe o valor do raio: ");
Raio = Convert.ToDouble(Console.ReadLine());

valordaarea = valordepi * (Raio * Raio);

Console.WriteLine($"\nO valor da área é: {valordaarea}m2.");