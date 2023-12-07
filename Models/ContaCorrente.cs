namespace studying_csharp.Models;

public class ContaCorrente : Conta
{
    public override void Creditar(decimal valor)
    {
        Saldo += valor;
    }
}