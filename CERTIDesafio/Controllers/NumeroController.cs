using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CERTIDesafio.Controllers
{
    [ApiController]
    public class NumeroController : ControllerBase
    {
        private readonly ILogger<NumeroController> _logger;

        public NumeroController(ILogger<NumeroController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        // Rota básica para receber parâmetro do número na URL
        [Route("{number:int}")] 
        // Add "Numero/" na URL para manter compatibilidade de versões anteriores
        [Route("Numero/{number:int}")]
        //**********************************************************************************
        // Comando HTTP GET
        // Recebe número entre -99999 e 99999 e formata para um string por extenso
        // Parâmetros:  int number
        //              Número decimal inteiro entre -99999 e 99999
        // Retorna: Json contendo o valor por extenso do número
        //**********************************************************************************
        public Numero Get(int number)
        {
            return (new Numero(number));
        }

        [Route("-Autoteste")]
        //**********************************************************************************
        // Comando HTTP GET
        // Teste unitário para validar todos os números do intervalo -99999 a 99999
        // Parâmetros:  
        // Retorna: string
        //          Um string contendo o valor numérico e por extenso de todos os números
        //          do intervalo -99999 a 99999 em ordem crescente
        //**********************************************************************************
        public string GetAllNumbers()
        {
            string str = "";
            for (int i = -99999; i <= 99999; i++)
            {
                Numero num = new Numero(i);
                str += i.ToString() + ": " + num.Extenso + "\n";
            }
            return (str);
        }
    }
}

