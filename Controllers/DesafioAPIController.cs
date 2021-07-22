using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Turma3desafio.Controllers
{
    [ApiController]
    [Route("[controlleraa]")]
    public class WeatherForecastController : ControllerBase
    {

        [HttpGet]
        public ActionResult Get()
        {

            DateTime dataLocal = DateTime.UtcNow;

            return BadRequest("Índia " + dataLocal.ToString("HH:mm:ss dd/MM/yyyy"));
        }

        [HttpGet]
        [Route("wordcount")]
        public ActionResult Count(string word)
        {

            string[] wordSplit = word.Select(x => x.ToString()).ToArray();
            int wordCount = wordSplit.Length;

            return Ok("A palavra \""+word+"\" tem "+ wordCount+" caracteres.");
        }

        [HttpGet]
        [Route("greetings")]
        public ActionResult Greetings(string name)
        {
            return Ok("Seja bem-vindo "+name);
        }
    }
}
