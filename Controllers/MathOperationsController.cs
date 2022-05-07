using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Straumann.Assignment.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MathOperationsController : ControllerBase
    {

        [HttpGet("add")]
        public int Add()
        {
            throw new NotImplementedException();
        }
        [HttpGet("subtract")]
        public int Subtract()
        {
            throw new NotImplementedException();
        }
        [HttpGet("multiple")]
        public int Multiple()
        {
            throw new NotImplementedException();
        }
        [HttpGet("divide")]
        public int Divide()
        {
            throw new NotImplementedException();
        }
        
        [HttpGet("getOpration")]
        public int Opration()
        {
            throw new NotImplementedException();
        }

    }
}
