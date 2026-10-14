// 3

Console.WriteLine("Nome do solicitante");
string solicitante = Console.ReadLine() ?? "";

Console.WriteLine("Idade");
int idade = int.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Salário Mensal");
double salario = double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Valor da Parcela");
double valorParcela = double.Parse(Console.ReadLine() ?? "0");

Console.WriteLine("Possui Restrição Financeira? (true/false)");
bool restricao = bool.Parse(Console.ReadLine() ?? "false");

double limiteParcela = salario * 0.30;

if (salario <= 0 || valorParcela <= 0)
{
    Console.WriteLine("Empréstimo recusado: dados financeiros inválidos.");
}
else if (idade < 18)
{
    Console.WriteLine("Empréstimo recusado: idade insuficiente.");
}
else if (restricao)
{
    Console.WriteLine("Empréstimo recusado: possui restrição financeira.");
}
else if (valorParcela > limiteParcela)
{
    Console.WriteLine("Empréstimo recusado: parcela acima do limite permitido.");
}
else
{
    Console.WriteLine($"Empréstimo aprovado para {solicitante}.");
    Console.WriteLine($"Limite da parcela: R$ {limiteParcela}");
    Console.WriteLine($"Parcela solicitada: R$ {valorParcela}");
}