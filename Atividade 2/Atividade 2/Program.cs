//ATIVIDADE 2
int nota1;
int nota2;
int soma;
int subtracao;
int multiplicacao;
int divisao;

Console.Write("Informe o seu primeiro número: ");
nota1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Informe o seu segundo número: ");
nota2 = Convert.ToInt32(Console.ReadLine());

soma = nota1 + nota2;
subtracao = nota1 - nota2;
multiplicacao = nota1 * nota2;
divisao = nota1 / nota2;

Console.WriteLine($"\nA soma dos valores é igual a {soma}, a subtração dos valores é de {subtracao}, a multiplicação dos valores é  {multiplicacao} e a divisão dos valores é igual a {divisao}");