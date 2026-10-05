# StreamingFlix

Projeto de exemplo com regras de negócio para planos de streaming: classificação por telas simultâneas, cálculo de descontos e validação de acesso a conteúdo adulto. Os testes unitários usam xUnit.

> O projeto contém uma biblioteca, não uma aplicação executável; portanto, não há interface para iniciar com `dotnet run`.

## Requisitos

- Git
- .NET SDK 10.0 ou posterior compatível (`net10.0`)

## Clonar e compilar

```bash
git clone https://github.com/arthurmdiniz/streaming-flix-xunit.git
cd streaming-flix-xunit
dotnet restore StreamingFlix.slnx
dotnet build StreamingFlix.slnx
```

## Executar os testes

Na pasta do repositório, rode:

```bash
dotnet test StreamingFlix.slnx
```

## Contribuidores

- Arthur Marques Diniz
- Luiz Filipe Pimenta
