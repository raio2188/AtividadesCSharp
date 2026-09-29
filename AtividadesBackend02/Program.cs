// 2
bool opval = false;
double temp = 0;

while (!opval)
{
    Console.WriteLine("Digite a temperatura");
    opval = double.TryParse(Console.ReadLine(), out temp);
}

if (temp < 10)
{
    Console.WriteLine("Muito Frio");
} else if (temp >= 10 && temp <= 17)
{
    Console.WriteLine("Frio");
} else if (temp >= 18 && temp <= 25)
{
    Console.WriteLine("Agradável");
} else if (temp >= 26 && temp <= 32)
{
    Console.WriteLine("Quente");
} else 
{
    Console.WriteLine("Muito Quente");
} 

if (temp <= 0)
{
    Console.WriteLine("Risco de congelamento");
}

if (temp >= 40)
{
    Console.WriteLine("Alerta de calor extremo");
}