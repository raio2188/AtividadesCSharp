// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");
Console.WriteLine("Meu primeiro programa em C#");

//Variáveis no C#
string nome = "Giusepe"; // string é usado para Textos
int idade = 18; // Int para valores inteiros. Ex: 1, 2, 3, 4, 5
double altura = 1.65; // Número com casas decimais e mais geral

// Exibindo as variáveis com interpolação no C#
Console.WriteLine($"Nome: {nome}");
Console.WriteLine($"Sua altura é de: {altura}");
Console.WriteLine($"Idade: {idade}");
Console.WriteLine($"nome é: {nome}, você tem {idade} anos");

// Entrada de dados / Perguntando ao usuário
Console.WriteLine("Digite seu nome: ");
string Aluno = Console.ReadLine() ?? "";    

//Saída / Exibir
Console.WriteLine($"O aluno se chama {Aluno}");

// Exemplo 2 - Conversões
Console.WriteLine("Digite sua idade: ");
// int age = int.Parse(Console.ReadLine() ?? "0"); 

bool converteu = int.TryParse(Console.ReadLine (), out int age);

if (converteu)
{
    Console.WriteLine($"O aluno tem {age} anos");
} 
else
{
    Console.WriteLine("Idade é inválida");
}

// Operadores Aritiméticos
int numero1 = 10;
int numero2 = 2;

Console.WriteLine($"Soma: {numero1 + numero2}");
Console.WriteLine($"Subtração: {numero1 - numero2}");
Console.WriteLine($"Multiplicação: {numero1 * numero2}");
Console.WriteLine($"Divisão: {numero1 / numero2}");
Console.WriteLine($"Resto {numero1 % numero2}");

// Operadores Relacionais
Console.WriteLine(numero1 == numero2);
Console.WriteLine(numero1 != numero2);
Console.WriteLine(numero1 > numero2);
Console.WriteLine(numero1 < numero2);
Console.WriteLine(numero1 >= numero2);
Console.WriteLine(numero1 <= numero2);

// Operadores Relacionais
int Idade = 20;
bool possuiIngresso = true;

if (Idade >= 18 && possuiIngresso)
{
    Console.WriteLine("Pode Entrar");
}
else
{
    Console.WriteLine("Não pode entrar");
}

// Exemplo com operador lógico OU "||"
// Basta apenas um cenário ser verdade
bool professor = false;
bool admin = true;

if(professor || admin)
{
    Console.WriteLine("Acesso Permitido!");
}
else
{
    Console.WriteLine("Acesso Recusado!");
}

if (idade >= 20)
{
    Console.WriteLine("Entrada Autorizada");   
}
else
{
    Console.WriteLine("Compre o ingresso!");
}