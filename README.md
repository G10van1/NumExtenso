# Transforma Número para Extenso
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
http://localhost:5001/78
```
Retorna:
```console
{"extenso":"setenta e oito"}
```
O servidor retorna um texto no formato JSON contendo o valor por extenso do número passado

## Imagem Docker

Clique no link abaixo para baixar a imagem do aplicativo para rodar no Docker:

[Download Imagem Docker](https://1drv.ms/u/s!AqDuCVVT4S07k2cEinuqaL0ajV2H?e=vfHALq)

Após baixar a imagem abra um prompt de comando e digite o comando abaixo na pasta do arquivo baixado para carregar a imagem.
```console
docker load <certidesafioimg.tar
```
Para iniciar o container digite o comando abaixo:
```console
docker run certidesafioapp
```
Para testar a aplicação abra outro prompt de comando.
Digite o comando abaixo para ver os contêineres em execução e pegar o CONTAINER ID do contêiner desejado.
```console
docker ps
```
Com o CONTAINER ID, execute o comando abaixo para exibir o endereço IP do contêiner.
```console
docker exec [CONTAINER ID] ipconfig
```
Para testar o aplicativo, copie o endereço IPv4 (por exemplo, 172.21.7.1) do contêiner e cole na barra de endereços do navegador passando o número a ser escrito por extenso na URL. Vide exemplo abaixo:
```console
http://172.21.7.1/78
```
Para maiores detalhes de como executar um aplicativo ASP.NET Core em contêineres do Docker acesse o link abaixo:

[ASP.NET Core em contêineres do Docker](https://docs.microsoft.com/pt-br/aspnet/core/host-and-deploy/docker/building-net-docker-images?view=aspnetcore-3.1)

## Link com o Aplicativo Instalado

[https://certidesafio.azurewebsites.net/11111](https://certidesafio.azurewebsites.net/11111)
