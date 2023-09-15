using Microsoft.AspNetCore.Mvc;

namespace wati
{

    public class ArithmeticController : Controller
    {
        [HttpPost("add")]
        public async Task<int> AddAsync([FromQuery]int num1, [FromQuery] int num2)
        {
            return num1 + num2;
        }
    }
}
