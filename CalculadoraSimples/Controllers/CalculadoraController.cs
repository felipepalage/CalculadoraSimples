using CalculadoraSimples.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CalculadoraSimples.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CalculadoraController : ControllerBase
    {
        [HttpGet]
        public ActionResult<Calculadora> somar(double valor1, double valor2)
        {
            var calc = new Calculadora(valor1,valor2);
            calc.Valor1 = valor1;
            calc.Valor2 = valor2;
            calc.somar();
            return Ok(valor1 + valor2);
        }

        [HttpGet]
        public ActionResult<Calculadora> Subtrair(double valor1, double valor2)
        {
            var calc = new Calculadora(valor1, valor2);
            calc.Valor1 = valor1;
            calc.Valor2 = valor2;
            calc.subtrair();
            return Ok(valor1 + valor2);
        }

        [HttpGet]
        public ActionResult<Calculadora> Multiplicar(double valor1, double valor2)
        {
            var calc = new Calculadora(valor1, valor2);
            calc.Valor1 = valor1;
            calc.Valor2 = valor2;
            calc.multiplicar();
            return Ok(valor1 + valor2);
        }

        [HttpGet]
        public ActionResult<Calculadora>dividir(double valor1, double valor2)
        {
            var calc = new Calculadora(valor1, valor2);
            calc.Valor1 = valor1;
            calc.Valor2 = valor2;
            calc.dividir();
            return Ok(valor1 + valor2);
        }
    }
}
