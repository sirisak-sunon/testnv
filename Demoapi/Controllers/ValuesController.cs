using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Demoapi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController
    {
        [HttpGet("[action]/{num1}/{num2}")]
        public int add(int num1 , int num2){
            int sum = num1 + num2;
            return sum;
        }
    }
}
