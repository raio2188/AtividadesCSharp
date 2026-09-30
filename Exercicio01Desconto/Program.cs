// 1

using System.Diagnostics;

Console.WriteLine("Digite seu nome");
string cliente = Console.ReadLine() ?? "";

Console.WriteLine("Digite o valor total");
double total = double.Parse(Console.ReadLine() ?? "false");

while (total < 0)
{
    Console.WriteLine("Digite um valor positivo");
    total = double.Parse(Console.ReadLine() ?? "false");
}

Console.WriteLine("Tem fidelidade?");
bool fidelidade = bool.Parse(Console.ReadLine() ?? "false");

double desconto = 0;

if (total >= 500)
{
    desconto = 0.15;
}
else if (total >= 200)
{
    desconto = 0.10;
}
else
{
    desconto = 0.05;
}

if (fidelidade)
{
    desconto += 0.05;
}

double valorDesconto = total * desconto;
double liquido = total - valorDesconto;

Console.WriteLine($"Cliente: {cliente}");
Console.WriteLine($"Compra: R$ {total}");
Console.WriteLine($"Desconto: R$ {valorDesconto}");
Console.WriteLine($"Valor Final: R$ {liquido}");