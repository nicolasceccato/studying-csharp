namespace studying_csharp.Models;

public class Calculadora
{
    public void Somar(double x, double y)
    {
        Console.WriteLine($"{x} + {y} = {x + y}");
    }
    public void Subtrair(double x, double y)
    {
        Console.WriteLine($"{x} - {y} = {x - y}");
    }
    public void Multiplicar(double x, double y)
    {
        Console.WriteLine($"{x} * {y} = {x * y}");
    }
    public void Dividir(double x, double y)
    {
        Console.WriteLine($"{x} / {y} = {x / y}");
    }
    public void Elevar(double x, double y)
    {
        Console.WriteLine($"{x} ^ {y} = {Math.Pow(x, y)}");
    }

}