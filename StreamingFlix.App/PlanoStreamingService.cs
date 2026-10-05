namespace StreamingFlix.App;

public class PlanoStreamingService
{
    public string ObterClassificacaoPorQualidade(int telasSimultaneas)
    {
        if (telasSimultaneas == 1)
        {
            return "BÁSICO";
        }
        else if (telasSimultaneas == 2)
        {
            return "PADRÃO";
        }
        else
        {
            return "PREMIUM";
        }
    }
    

    public double CalcularMensalidadeComDesconto(double valorBase, int mesesContratados)
    {
        if (mesesContratados is >= 6 and <= 11)
        {
            return (double) ((valorBase / 100) * 90); // 10% de desconto
        }
        else if (mesesContratados >= 12)
        {
            return (double)((valorBase / 100) * 80); // 20% de desconto
        }
        else
        {
            return valorBase; 
        }
    }

    public bool PodeAcessarConteudoAdulto(int idade, bool controleParentalAtivo)
    {
        if (controleParentalAtivo)
        {
            return false;
        }

        return idade >= 18 || controleParentalAtivo;
    }

}


