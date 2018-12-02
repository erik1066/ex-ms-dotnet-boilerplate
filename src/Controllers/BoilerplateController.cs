#pragma warning disable 1591 // disables the warnings about missing Xml code comments

using System;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Foundation.Example.WebUI.Models;
using Swashbuckle.AspNetCore.Annotations;

namespace Foundation.Example.WebUI.Controllers
{
    [Route("api/1.0")]
    [ApiController]
    public sealed class BoilerplateController : ControllerBase
    {
        public BoilerplateController()
        {
        }

        // GET api/1.0/add/2/2
        /// <summary>
        /// Adds two numbers
        /// </summary>
        /// <returns>Sum of two numbers</returns>
        [Produces("application/json")]
        [HttpGet("add/{firstNumber}/{secondNumber}")]
        [SwaggerResponse(200, "If the two numbers were added successfully", typeof(SumResult))]
        [SwaggerResponse(400, "If one or both numbers are invalid")]
        public IActionResult Index([FromRoute] int firstNumber, [FromRoute] int secondNumber)
        {
            var result = new SumResult()
            {
                FirstNumber = firstNumber,
                SecondNumber = secondNumber,
                Sum = (firstNumber + secondNumber)
            };
            return Ok(result);
        }
    }
}

#pragma warning restore 1591