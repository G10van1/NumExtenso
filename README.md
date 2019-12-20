# Desafio CERTI
Este aplicativo é um HTTP Server do tipo WEB API.
Transforma um número decimal inteiro em um string por extenso.
O número deve estar no intervalo [-99999,99999].

## Ferramentas e Tecnologias Utilizadas

- Microsoft Visual Studio 2019 Community
- .NET Core e [ASP.NET Core 3.1](https://github.com/aspnet/AspNetCore.Docs)
- C#

## Descritivo Funcional

Digite a URL do servidor passando o número a ser formatado no final da URL, conforme exemplo abaixo:

```console
http://localhost:5001/Numero/78
```
Retorna:
```console
{"extenso":"setenta e oito"}
```
O servidor retorna um JSON contendo o valor por extenso do número passado

## Imagem Docker

Clique no link abaixo para baixar a imagem do aplicativo para rodar no Docker:

[Imagem Docker](https://1drv.ms/u/s!AqDuCVVT4S07k2cEinuqaL0ajV2H?e=vfHALq)

Após baixar a imagem digite o comando abaixo para carregar a imagem na pasta "tmp" ou altere para outro caminho.
```console
docker load </tmp/certidesafioimg.tar
```

Para saber como executar um aplicativo ASP.NET Core em contêineres do Docker use o link abaixo:

[ASP.NET Core em contêineres do Docker](https://docs.microsoft.com/pt-br/aspnet/core/host-and-deploy/docker/building-net-docker-images?view=aspnetcore-3.1)

Após rodar o aplicativo abra o navegador e digite o número IP do container, "/Numero/" e o número a ser escrito por extenso. Vide exemplo abaixo:

```console
http://172.21.7.1/Numero/78
```

## Link com o Aplicativo Instalado

[https://certidesafio.azurewebsites.net/Numero/11111](https://certidesafio.azurewebsites.net/Numero/11111)
