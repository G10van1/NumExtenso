# CERTIDesafio
Este aplicativo é um HTTP Server do tipo WEB API.
Transforma um número decimal inteiro em um string por extenso.
O número deve estar no intervalo [-99999,99999].

## Ferramentas e Tecnologias Utilizadas

- Microsoft Visual Studio 2019 Community
- .NET Core e [ASP.NET Core 3.1](https://github.com/aspnet/AspNetCore.Docs)
- C#

## Descritivo funcional

Digite a URL do servidor passando o número a ser formatado no final da URL, conforme exemplo abaixo:

```console
http://localhost:5001/Numero/78
```
Retorna:
```console
{"extenso":"setenta e oito"}
```
O servidor retorna um JSON contendo o valor por extenso do número passado

## Link com o aplicativo instalado

[https://certidesafio.azurewebsites.net/Numero/11111](https://certidesafio.azurewebsites.net/Numero/11111)
