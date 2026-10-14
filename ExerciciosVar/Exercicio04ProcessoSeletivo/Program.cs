// 4

Console.WriteLine("Nome do candidato:");
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

int experiencia = 0;
bool experienciaValida = false;

while (!experienciaValida)
{
    Console.WriteLine("Anos de experiência:");

    experienciaValida = int.TryParse(Console.ReadLine(), out experiencia);

    if (!experienciaValida || experiencia < 0)
    {
        Console.WriteLine("Experiência inválida.");
        experienciaValida = false;
    }
}

double nota = 0;
bool notaValida = false;

while (!notaValida)
{
    Console.WriteLine("Nota da prova técnica:");

    notaValida = double.TryParse(Console.ReadLine(), out nota);

    if (!notaValida || nota < 0 || nota > 10)
    {
        Console.WriteLine("Nota inválida.");
        notaValida = false;
    }
}

Console.WriteLine("Possui curso técnico? (true/false)");
bool cursoTecnico = bool.Parse(Console.ReadLine() ?? "false");

Console.WriteLine("Possui disponibilidade de horário? (true/false)");
bool disponibilidade = bool.Parse(Console.ReadLine() ?? "false");

if (
    idade >= 18 &&
    nota >= 7 &&
    disponibilidade &&
    (experiencia >= 2 || cursoTecnico)
)
{
    Console.WriteLine($"Candidato: {nome}");
    Console.WriteLine("Resultado: Aprovado");
}
else if (
    nota >= 5 &&
    nota < 7 &&
    disponibilidade &&
    (cursoTecnico || experiencia > 0)
)
{
    Console.WriteLine($"Candidato: {nome}");
    Console.WriteLine("Resultado: Banco de talentos");
}
else
{
    Console.WriteLine($"Candidato: {nome}");
    Console.WriteLine("Resultado: Reprovado");

    if (idade < 18)
    {
        Console.WriteLine("Motivo: idade insuficiente.");
    }
    else if (nota < 5)
    {
        Console.WriteLine("Motivo: nota técnica insuficiente.");
    }
    else if (!disponibilidade)
    {
        Console.WriteLine("Motivo: indisponibilidade de horário.");
    }
    else if (experiencia < 2 && !cursoTecnico)
    {
        Console.WriteLine("Motivo: experiência insuficiente e ausência de curso técnico.");
    }
    else
    {
        Console.WriteLine("Motivo: não atende aos critérios da vaga.");
    }
}