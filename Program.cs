﻿using studying_csharp.Models;
/*
Pessoa p = new Pessoa();
p.Nome = "Ronaldo";
p.Idade = 200;
Console.WriteLine(p.Nome);

decimal valor = 1.900000m;

double altura = 1.77;

Console.WriteLine(valor);

Console.WriteLine(altura.ToString("0.00000"));

DateTime data = DateTime.Now;
data.ToString("yyyy MMMM dd");

int a = Convert.ToInt32("5");
string b = Convert.ToString(null);

Console.WriteLine(a);
Console.WriteLine(b);

if (1 > 2)
{
    Console.WriteLine("1 é maior que 2");
}
else if (2 == 1)
{
    Console.WriteLine("2 é igual a 1");
}
else
{
    Console.WriteLine("2 é maior que 1");
}
*/

Console.WriteLine("Digite uma letra: ");
string letra = Console.ReadLine();

switch (letra)
{
    case "a":
    case "e":
    case "i":
    case "o":
    case "u":
        Console.WriteLine("VOGAL!!!!");
        break;    
    default:
        Console.WriteLine("Nao vogal!");
        break;
        
}