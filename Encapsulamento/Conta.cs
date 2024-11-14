public class Conta
{
    private double _Saldo;


    public void SetSaldo(double s)
    {
        try
        {
            if (s <= 0)
            {
                Console.WriteLine("Ta errado meu patrão");
            }
            else { _Saldo = s; }
        }
        catch (Exception ex)
        {
            throw new Exception(ex.Message);// executa as exeções
        }
    }

    public double GetSaldo() { 

        return _Saldo;
    
    }

}