using Microsoft.AspNetCore.Mvc;

namespace ApiExemplo.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class UsuarioController : Controller
    {
        [HttpGet("ObterDataHoraAtual")]
        public IActionResult Index()
        {
            var obj = new
            {
                Data = DateTime.Now.ToLongDateString(),
                Hora = DateTime.Now.ToShortDateString()
            };
            return Ok(obj);
        }

        [HttpGet("Apresentar")]
        public IActionResult Apresentar(string nome)
        {
            var mensagem = $"Olá {nome}, seja bem vindo!";
            return Ok(new { mensagem });
        }

        [HttpGet("Consult/IRPF/{wage}")]
        public IActionResult IRPFDiscount(decimal wage)
        {
            decimal wageDiscount = 0m;

            if (wage < 2112m)
            {
                wageDiscount = wage;
            }
            else if (wage <= 2826.66m)
            {
                wageDiscount = wage * .075m;
            }
            else if (wage <= 3751.06m)
            {
                wageDiscount = wage * .015m;
            }
            else if (wage <= 4664.68m)
            {
                wageDiscount = wage * .0225m;
            }
            else
            {
                wageDiscount = wage * .0275m;
            }
            return Ok(new { wageDiscount });
        }

        [HttpGet("Consult/INSS/{wage}")]
        public IActionResult INSSDiscount(decimal wage)
        {
            decimal wageDiscount = 0m;

            if (wage < 2112.00m)
            {
                wageDiscount = wage;
            }
            else if (wage <= 2826.65m)
            {
                wageDiscount = wage * .075m;
            }
            else if (wage <= 3751.05m)
            {
                wageDiscount = wage * .015m;
            }
            else if (wage <= 4664.68m)
            {
                wageDiscount = wage * .0225m;
            }
            else
            {
                wageDiscount = wage * .0275m;
            }
            return Ok(new { wageDiscount });
        }
    }
}
