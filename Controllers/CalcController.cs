using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace unittest.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CalcController : ControllerBase
    {
        [HttpGet("{a}/{b}")]
        public ActionResult CalculateSum(int a, int b){
            int sum=a+b;
            string res="{'sum' : "+sum+"}";
            Console.WriteLine(res);
            return Ok(res);
        }
    }



}