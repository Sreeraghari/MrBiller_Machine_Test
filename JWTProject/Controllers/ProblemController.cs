using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace JWTProject.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProblemController : ControllerBase
    {
        [HttpGet("perfectnumber/{number}")]
        public IActionResult CheckPerfectNumber(int number)
        {
            if (IsPerfectNumber(number))
            {
                return Ok(new { number, isPerfect = true, message = $"{number} is a Perfect Number." });
            }
            else
            {
                return Ok(new { number, isPerfect = false, message = $"{number} is NOT a Perfect Number." });
            }
        }

        private bool IsPerfectNumber(int number)
        {
            int sum = 0;

            for (int i = 1; i <= number / 2; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }
            return sum == number;
        }

        [HttpGet("ninteen/{number}")]
        public IActionResult MatchNumberNinteen(int number)
        {
            int ninteen = number == 19 ? number : throw new Exception("Number is not 19");

            var result = GetFinalNumber(ninteen);
            return Ok(result);
        }

        private static List<int> GetFinalNumber(int n)
        {
            List<int> sequence = new();

            while (n != 1)
            {
                sequence.Add(n);
                n = GetSumOfSquares(n);
            }
            sequence.Add(1);

            return sequence;
        }

        private static int GetSumOfSquares(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                int digit = num % 10;
                sum += digit * digit;
                num /= 10;
            }
            return sum;
        }
    }
}