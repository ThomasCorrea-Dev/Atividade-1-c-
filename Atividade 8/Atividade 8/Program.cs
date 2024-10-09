//ATIVIDADE 8
double celcius;
double Fahrenheit;
double calculof;

Console.Write("Digite a temperatura em Celsius para saber em Fahrenheit: ");
celcius = Convert.ToDouble(Console.ReadLine());

calculof = (celcius * 9 / 5) + 32;

Console.WriteLine($"A temperatura celcius: {celcius} graus em Fahrenheit e de: {calculof}");