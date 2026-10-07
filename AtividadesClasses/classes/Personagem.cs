using System;

namespace Classes;

public class Personagem
{
    public string Nome = "";
    public int Energia;
    
    // Funções void não exigem Return
    public void RecuperarEnergia(int pontos, string motivo)
    {
        Energia += pontos;
        Console.WriteLine($"{Nome} recuperou {pontos} pontos: {motivo}");
    }

}
