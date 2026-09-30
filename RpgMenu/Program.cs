string Nome = "Raio";
int HP = 100;
int MP = 50;
int Ataque = 15;
int Defesa = 8;
int Ouro = 20;
Random sorteador = new Random();

void status(string Nome, int HP, int MP, int Ataque, int Defesa, int Ouro)
{
    Console.WriteLine("=== Personagem ===");
    Console.WriteLine(Nome);
    Console.WriteLine(HP);
    Console.WriteLine(MP);
    Console.WriteLine(Ataque);
    Console.WriteLine(Defesa);
    Console.WriteLine(Ouro);
}

void explorar()
{
    int evento = sorteador.Next(1, 5);
    int tesouro = sorteador.Next(1, 11);
    int dano = sorteador.Next(1, 6);


    if (evento == 1)
    {
        Ouro += tesouro;
        Console.WriteLine($"Você encontrou um tesouro! \n Você agora tem {Ouro} ouros!");
    }
    else if (evento == 2)
    {
        HP -= dano;
        Console.WriteLine($"Você caiu em uma armadilha! \n Seu HP agora é {HP}");
    }
    else if (evento == 3)
    {
        Console.WriteLine("Você não encontra nada em sua jornada");
    } 
    else if (evento == 4)
    {
        Console.WriteLine("Um goblin apareceu!");
    }
    else
    {
        Console.WriteLine("Fodeu.");
    }
}

status(Nome, HP, MP, Ataque, Defesa, Ouro);


bool jogando = true;

while(jogando)
{
    Console.WriteLine("\n=== Menu ===");
    Console.WriteLine("1 - Ver Status");
    Console.WriteLine("2 - Explorar");
    Console.WriteLine("3 - Loja");
    Console.WriteLine("4 - Descansar");
    Console.WriteLine("5 - Sair");  
    int acao = int.Parse(Console.ReadLine() ?? "");

    switch (acao){
    case 1:
        status(Nome, HP, MP, Ataque, Defesa, Ouro);
        break;
    case 2:
        explorar();
        break;
    case 3:
        Console.WriteLine("WIP");
        break;
    case 4:
        Console.WriteLine("WIP");
        break;
    case 5:
        jogando = false;
        break;
    default:
        Console.WriteLine("Escolha uma ação válida");
        break;
    }
if(HP < 1)
    {
        Console.WriteLine("Você morreu! \n Finalizando sua aventura...");
        jogando = false;
    }
}