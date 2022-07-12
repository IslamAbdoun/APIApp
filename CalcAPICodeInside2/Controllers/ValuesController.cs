using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalcLibraryCode;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalcAPICodeInside2.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        Calc calc = new Calc();
        // GET: api/<ValuesController>
        [HttpGet("/average")]
        public int Average([FromQuery] int[] nums)
        {
            return calc.average(nums);
        }

        [HttpGet("/smallest")]
        public int smallest([FromQuery] int[] nums)
        {
            return calc.smallest(nums);
        } 

        [HttpGet("/largest")]
        public int largest([FromQuery] int[] nums)
        {
            return calc.lagest(nums);

        }

    }

}
