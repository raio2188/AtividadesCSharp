// 6

using System.Globalization;

Console.WriteLine("Nome do paciente:");
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

double temperatura = 0;
bool temperaturaValida = false;

while (!temperaturaValida)
{
    Console.WriteLine("Temperatura:");

    string entrada = (Console.ReadLine() ?? "").Replace(',', '.');

    temperaturaValida = double.TryParse(
        entrada,
        CultureInfo.InvariantCulture,
        out temperatura
    );

    if (!temperaturaValida || temperatura < 30 || temperatura > 45)
    {
        Console.WriteLine("Temperatura inválida.");
        temperaturaValida = false;
    }
}

int dor = 0;
bool dorValida = false;

while (!dorValida)
{
    Console.WriteLine("Nível de dor (0 a 10):");

    dorValida = int.TryParse(Console.ReadLine(), out dor);

    if (!dorValida || dor < 0 || dor > 10)
    {
        Console.WriteLine("Nível de dor inválido.");
        dorValida = false;
    }
}

Console.WriteLine("Possui dificuldade para respirar? (true/false)");
bool dificuldadeRespirar = bool.Parse(Console.ReadLine() ?? "false");

Console.WriteLine("Está consciente? (true/false)");
bool consciente = bool.Parse(Console.ReadLine() ?? "false");

Console.WriteLine();
Console.WriteLine($"Paciente: {nome}");

if (!consciente)
{
    Console.WriteLine("Classificação: Emergência");
    Console.WriteLine("Motivo: paciente inconsciente.");
}
else if (dificuldadeRespirar)
{
    Console.WriteLine("Classificação: Emergência");
    Console.WriteLine("Motivo: dificuldade para respirar.");
}
else if (dor >= 9)
{
    Console.WriteLine("Classificação: Emergência");
    Console.WriteLine("Motivo: nível de dor muito elevado.");
}
else if (temperatura >= 39)
{
    Console.WriteLine("Classificação: Urgente");
    Console.WriteLine("Motivo: temperatura elevada.");
}
else if (dor >= 7 && dor <= 8)
{
    Console.WriteLine("Classificação: Urgente");
    Console.WriteLine("Motivo: nível de dor elevado.");
}
else if (idade >= 60 && temperatura >= 38)
{
    Console.WriteLine("Classificação: Urgente");
    Console.WriteLine("Motivo: paciente idoso com temperatura elevada.");
}
else if (idade < 12)
{
    Console.WriteLine("Classificação: Prioritário");
    Console.WriteLine("Motivo: paciente menor de 12 anos.");
}
else if (idade >= 60)
{
    Console.WriteLine("Classificação: Prioritário");
    Console.WriteLine("Motivo: paciente idoso.");
}
else if (temperatura >= 37.5 && temperatura <= 38.9)
{
    Console.WriteLine("Classificação: Prioritário");
    Console.WriteLine("Motivo: temperatura acima do normal.");
}
else
{
    Console.WriteLine("Classificação: Atendimento comum");
    Console.WriteLine("Motivo: nenhum critério de prioridade identificado.");
}