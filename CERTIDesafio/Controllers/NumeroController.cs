using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace CERTIDesafio.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NumeroController : ControllerBase
    {
        private readonly ILogger<NumeroController> _logger;

        public NumeroController(ILogger<NumeroController> logger)
        {
            _logger = logger;
        }

        [HttpGet]

        [Route("{number:int}")]
        public Numero Get(int number)
        {
            return (new Numero(number));
        }

        [HttpGet]
        [Route("-Autoteste")]
        public string Get()
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

