﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestComAspNet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculadoraController : ControllerBase
    {
        private readonly ILogger<CalculadoraController> _logger;

        public CalculadoraController(ILogger<CalculadoraController> logger)
        {
            _logger = logger;
        }

        [HttpGet("adicao/{primeiroNumero}/{segundoNumero}")]
        public IActionResult Adicao(string primeiroNumero, string segundoNumero)
        {
            if (IsNumeric(primeiroNumero) && IsNumeric(segundoNumero))
            {
                var soma = ConvertToDecimal(primeiroNumero) + ConvertToDecimal(segundoNumero);
                return Ok(soma.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("subtracao/{primeiroNumero}/{segundoNumero}")]
        public IActionResult Subtracao(string primeiroNumero, string segundoNumero)
        {
            if (IsNumeric(primeiroNumero) && IsNumeric(segundoNumero))
            {
                var soma = ConvertToDecimal(primeiroNumero) - ConvertToDecimal(segundoNumero);
                return Ok(soma.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("divisao/{primeiroNumero}/{segundoNumero}")]
        public IActionResult Divisao(string primeiroNumero, string segundoNumero)
        {
            if (IsNumeric(primeiroNumero) && IsNumeric(segundoNumero))
            {
                var soma = ConvertToDecimal(primeiroNumero) / ConvertToDecimal(segundoNumero);
                return Ok(soma.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("multiplicacao/{primeiroNumero}/{segundoNumero}")]
        public IActionResult Multiplicacao(string primeiroNumero, string segundoNumero)
        {
            if (IsNumeric(primeiroNumero) && IsNumeric(segundoNumero))
            {
                var soma = ConvertToDecimal(primeiroNumero) * ConvertToDecimal(segundoNumero);
                return Ok(soma.ToString());
            }

            return BadRequest("Invalid Input");
        }

        [HttpGet("raizquadrada/{primeiroNumero}")]
        public IActionResult RaizQuadrada(string primeiroNumero)
        {
            if (IsNumeric(primeiroNumero))
            {
                var raizQuadrada = Math.Sqrt((double)ConvertToDecimal(primeiroNumero)); 
                return Ok(raizQuadrada.ToString());
            }

            return BadRequest("Invalid Input");
        }
        private bool IsNumeric(string strNumero)
        {
            double number;
            bool isNumber = double.TryParse(strNumero, System.Globalization.NumberStyles.Any,
                System.Globalization.NumberFormatInfo.InvariantInfo, out number);
            return isNumber;
        }

        private decimal ConvertToDecimal(string strNumero)
        {
            decimal decimalValue;
            if (decimal.TryParse(strNumero, out decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }       
    }
}
