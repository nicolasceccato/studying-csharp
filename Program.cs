using studying_csharp.Models;

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