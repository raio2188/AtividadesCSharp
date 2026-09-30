using System.Reflection;
using System.Reflection.Metadata;

void calcular(int num1, int num2, char operacao)
{
    bool valido = false;
    bool num2val2 = false;

    while(!valido)
    {
        switch (operacao){
        case '+':
            Console.WriteLine(num1 + num2);
            valido = true;
            break;
        case '-':
            Console.WriteLine(num1 - num2);
            valido = true;
            break;
        case '*':
            Console.WriteLine(num1 * num2);
            valido = true;
            break;
        case '/':
            if (num2 == 0)
                {
                    Console.WriteLine("Operação Inválida");
                    Console.WriteLine("Digite seu segundo número");
                    num2val2 = int.TryParse(Console.ReadLine(), out num2);
                }
            else
                {
                    Console.WriteLine((double)num1 / num2);  
                    valido = true;
                }
            break;
        default:
            Console.WriteLine("Operação Inválida");
            Console.WriteLine("Digite seu operador");
            operacao = char.Parse(Console.ReadLine() ?? "");
            break;
       }
    }
}

bool num1val = false;
bool opval = false;
bool num2val = false;

int num1 = 0;
int num2 = 0;
char operacao = ' ';


while (!num1val)
{
    Console.WriteLine("Digite O Primeiro Número");
    num1val = int.TryParse(Console.ReadLine(), out num1);

    if (num1val)
    {
        Console.WriteLine("Digite o Operador");
    }
    else
    {
        Console.WriteLine("Digite um número Válido");
    }
}

while (!opval)
{
    opval = char.TryParse(Console.ReadLine(), out operacao);

    if (opval)
    {
        Console.WriteLine("Digite o Segundo Número");
    }
    else
    {
        Console.WriteLine("Digite um operador válido");
    }
}

while (!num2val)
{
    num2val = int.TryParse(Console.ReadLine(), out num2);

    if (num2val)
    {
        calcular(num1, num2, operacao);
    }
    else
    {
        Console.WriteLine("Digite um número Válido");
    }
}