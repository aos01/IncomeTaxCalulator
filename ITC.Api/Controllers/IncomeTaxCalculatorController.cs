using ITC.Service.Interfaces;
using ITC.Services;
using Microsoft.AspNetCore.Mvc;
using System.Net;

namespace ITC.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class IncomeTaxCalculatorController : ControllerBase
    {
        private readonly IDetailedIncomeTaxCalculatorService _detailedIncomeTaxCalculatorService;

        public IncomeTaxCalculatorController(IDetailedIncomeTaxCalculatorService detailedIncomeTaxCalculatorService)
        {
            _detailedIncomeTaxCalculatorService = detailedIncomeTaxCalculatorService;
        }

        // GET api/<IncomeTaxCalculatorController>/1000
        [HttpGet("{income}")]
        public async Task<ActionResult<string>> Get(int income)
        {
            if (income <= 0)
            {
                return StatusCode(StatusCodes.Status400BadRequest);
            }

            var detailedIncomeTax = await _detailedIncomeTaxCalculatorService.GetDetailedIncomeTax(income).ConfigureAwait(false);

            return Ok(detailedIncomeTax);
        }
    }
}
