using Exercicio02Livros;

Ambiente Sala = new Ambiente();

Sala.Nome = "Sala";
Sala.Largura = 4.0;
Sala.Comprimento = 6.0;

Ambiente Quarto = new Ambiente();

Quarto.Nome = "Quarto";
Quarto.Largura = 3.0;
Quarto.Comprimento = 3.5;

Sala.ExibirMedidas();
Console.WriteLine(); // pular linha

Quarto.ExibirMedidas();

double AreaSala = Sala.CalcularArea();
double AreaQuarto = Quarto.CalcularArea();

Console.WriteLine($"Área da sala: {AreaSala}");
Console.WriteLine(); // pular linha

Console.WriteLine($"Área do quarto: {AreaQuarto}");
Console.WriteLine(); // pular linha

Console.WriteLine($"Área total: {AreaSala + AreaQuarto}");