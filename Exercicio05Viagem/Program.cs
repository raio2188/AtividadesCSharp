// 5

using System.Globalization;

Console.WriteLine("Nome do passageiro:");
string nome = Console.ReadLine() ?? "";

int idade = 0;
bool idadeValida = false;

while (!idadeValida)
{
    Console.WriteLine("Idade:");

    idadeValida = int.TryParse(Console.ReadLine(), out idade);

    if (!idadeValida || idade < 0)
    {
        Console.WriteLine("Idade inválida.");
        idadeValida = false;
    }
}

double distancia = 0;
bool distanciaValida = false;

while (!distanciaValida)
{
    Console.WriteLine("Distância em quilômetros:");

    string entrada = (Console.ReadLine() ?? "").Replace(',', '.');

    distanciaValida = double.TryParse(
        entrada,
        CultureInfo.InvariantCulture,
        out distancia
    );

    if (!distanciaValida || distancia <= 0)
    {
        Console.WriteLine("Distância inválida.");
        distanciaValida = false;
    }
}

Console.WriteLine("A viagem acontecerá em horário de pico? (true/false)");
bool horarioPico = bool.Parse(Console.ReadLine() ?? "false");

Console.WriteLine("Possui cartão de desconto? (true/false)");
bool cartaoDesconto = bool.Parse(Console.ReadLine() ?? "false");

double valorBase = distancia * 0.80;
double valorFinal = valorBase;

// 1. valor base já calculado

// 2. acréscimo do horário de pico
if (horarioPico)
{
    valorFinal += valorFinal * 0.20;
}

// 3. desconto por idade
if (idade < 6)
{
    valorFinal = 0;
}
else if (idade <= 17)
{
    valorFinal -= valorFinal * 0.50;
}
else if (idade >= 60)
{
    valorFinal -= valorFinal * 0.40;
}

// 4. desconto do cartão
if (cartaoDesconto && valorFinal > 0)
{
    valorFinal -= valorFinal * 0.10;
}

Console.WriteLine();
Console.WriteLine($"Passageiro: {nome}");
Console.WriteLine($"Valor base: R$ {valorBase:F2}");
Console.WriteLine($"Valor final: R$ {valorFinal:F2}");