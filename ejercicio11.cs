using System;

public class CuentaBancaria
{
    private decimal Saldo;

    public void Depositar(decimal monto)
    {
        if(monto > 0)
        {
            Saldo += monto;
        }
    }
    public void Retirar(decimal monto)
    {
        if(Saldo >= monto && monto> 0)
        {
            Saldo -= monto;
        }
    }
}