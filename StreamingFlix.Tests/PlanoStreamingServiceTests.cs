using Xunit;
using StreamingFlix.App;


namespace StreamingFlix.Tests;

public class PlanoStreamingServiceTests
{
	[Theory]
	[InlineData(1, "BÁSICO")]
	[InlineData(2, "PADRÃO")]
	[InlineData(4, "PREMIUM")]
	public void ClassificarPlano(int telas, string planoEsperado)
    {
        var planoService = new PlanoStreamingService();

        var plano = planoService.ObterClassificacaoPorQualidade(telas);

        Assert.Equal(planoEsperado, plano);
    }

	[Theory]
	[InlineData(50, 1, 50)]
	[InlineData(50, 6, 46)]
	[InlineData(50, 12, 40)]
	public void CalcularDesconto(int valor, int mesesContratados, double valorEsperado)
	{
		var calculadora = new PlanoStreamingService();

		var resultado = calculadora.CalcularMensalidadeComDesconto(valor, mesesContratados);

		Assert.Equal(valorEsperado, resultado);
	}

	[Theory]
	[InlineData(20, false, true)]
	[InlineData(20, true, false)]
	[InlineData(16, false, false)]
	public void ValidarAcesso(int idade, bool controleParental, bool retornoEsperado)
	{
		var calculadora = new PlanoStreamingService();

		var elegivel = calculadora.PodeAcessarConteudoAdulto(idade, controleParental);

		Assert.Equal(retornoEsperado, elegivel);
	}
}