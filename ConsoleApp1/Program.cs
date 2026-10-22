Console.Write("Digite um número inteiro: ");
int numero = int.Parse(Console.ReadLine());

int dobro = numero * 2;

Console.WriteLine(dobro);


Console.Write("Digite o primeiro número:");
int A = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo número:");
int B = int.Parse(Console.ReadLine());

int soma = A + B;

Console.WriteLine("Soma =" + soma);







Console.Write("Escolha um número ímpar ou par:");
int numero1 = int.Parse(Console.ReadLine());
if (numero1 % 2 == 0)
{
    Console.WriteLine("Par");
}
else
{
    Console.WriteLine("Ímpar");
}










Console.Write("Digite o primeiro número:");
int A1 = int.Parse(Console.ReadLine());

Console.Write("Digite o segundo número:");
int B1 = int.Parse(Console.ReadLine());

if (A1 > B1)
{
    Console.WriteLine(A1);
}
else
{
    Console.WriteLine(B1);
}









Console.Write("Digite sua idade:");
int idade = int.Parse(Console.ReadLine());

if (idade >= 18)
{
    Console.WriteLine("Maior de idade");
}
else
{
    Console.WriteLine("Menor de idade");
}











Console.Write("Digite sua primeira nota:");
int A3 = int.Parse(Console.ReadLine());

Console.Write("Digite sua segunda nota:");
int B3 = int.Parse(Console.ReadLine());

int media = (A3 + B3) / 2;

if (media >= 6)
{
    Console.WriteLine("Aprovado");
}
else
{
    Console.WriteLine("Reprovado");
}









Console.Write("Informe seu número:");
int numero2 = int.Parse(Console.ReadLine());

if (numero2 >= 50 && numero2 <= 100)
{
    Console.WriteLine("Está entre 50 e 100");
}
else
{
    Console.WriteLine("Não está entre 50 e 100");
}










Console.Write("Informe o valor do produto:");
int valor = int.Parse(Console.ReadLine());

if (valor >= 100)
{
    Console.WriteLine($"Valor final: {valor - (valor * 0.10)}");
}
else
{
    Console.WriteLine($"Valor final:{valor}");
}










Console.Write("Digite um número:");
int numero3 = int.Parse(Console.ReadLine());

if (numero3 > 0)
{
    Console.WriteLine("Número positivo");
}
else if (numero3 < 0)
{
    Console.WriteLine("Número negativo");
}
else
{
    Console.WriteLine("Zero");
}










Console.Write("Informe sua idade:");
int idade1 = int.Parse(Console.ReadLine());

if (idade1 >= 16)
{
    Console.WriteLine("Pode votar");
}
else
{
    Console.WriteLine("Não pode votar");
}










int distancia = 30 * 16;
int dias = distancia / 20;
int espera = dias - 16;

Console.WriteLine("Exercício 1: " + espera + "dias");










int soma1 = 1 + 2 + 3 + 4 + 5 + 6 + 7;
int cartas = 52 - soma1;

Console.WriteLine($"{cartas}Cartas formam o monte");










int sabores = 3;
int bordas = 2;
int tamanhos = 2;

int combinacoes = sabores * bordas * tamanhos;

Console.WriteLine("Exercício 3: " + combinacoes + "combinações");