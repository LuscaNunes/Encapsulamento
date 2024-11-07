public class Conta
{
    private double _Saldo;


    public void SetSaldo(double s)
    {
        if (s <= 0)
        {
            Console.WriteLine("Ta errado meu patrão");
        }
        else { _Saldo = s; }

    }

    public double GetSaldo() { 

        return _Saldo;
    
    }

}