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

    public void Seno(double angulo)
    {
        double radiano = angulo * Math.PI / 180;
        Console.WriteLine($"Seno de {angulo} = {Math.Sin(radiano)}");
    }
    public void Coseno(double angulo)
    {
        double radiano = angulo * Math.PI / 180;
        Console.WriteLine($"Coseno de {angulo} = {Math.Cos(radiano)}");
    }
    public void Tangente(double angulo)
    {
        double radiano = angulo * Math.PI / 180;
        Console.WriteLine($"Tangente de {angulo} = {Math.Tan(radiano)}");
    }

    public void RaizQuadrada(double valor)
    {
        double raiz = Math.Sqrt(valor);
        Console.WriteLine($"Raiz de {valor} = {Math.Round(raiz, 4)}");
    }

}