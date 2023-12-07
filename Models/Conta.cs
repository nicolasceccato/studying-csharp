namespace studying_csharp.Models;

public abstract class Conta
{
    protected decimal Saldo;

    public void ExibirSaldo()
    {
        Console.WriteLine($"O seu saldo é igual a {Saldo}");
    }

    public abstract void Creditar(decimal valor);
}