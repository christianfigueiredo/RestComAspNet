using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestComAspNet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PersonController : ControllerBase
    {
        private readonly ILogger<PersonController> _logger;

        public PersonController(ILogger<PersonController> logger)
        {
            _logger = logger;
        }

        [HttpGet("adicao/{primeiroNumero}/{segundoNumero}")]
        public IActionResult Adicao(string primeiroNumero, string segundoNumero)
        {         

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
