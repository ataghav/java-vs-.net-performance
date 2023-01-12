using Microsoft.AspNetCore.Mvc;

namespace javavsdotnetperformance.Controllers;

[ApiController]
[Route("[controller]")]
public class PrimesController : ControllerBase
{

    private readonly ILogger<PrimesController> _logger;

    public PrimesController(ILogger<PrimesController> logger)
    {
        _logger = logger;
    }

    [HttpGet]
    public IEnumerable<Int32> Get()
    {
        return retainPrimes(Enumerable.Range(1, 1000).ToList()); //new List<Int32>(){55,44};
    }

    private IEnumerable<Int32> retainPrimes(IEnumerable<Int32> numbers)
    {
        return numbers.Where(num => isPrime(num));

    }

    private Boolean isPrime(Int32 number)
    {
        var isPrime = true;
        if (number < 2)
        {
            isPrime = false;
        }
        else
        {
            var count = Enumerable.Range(2, number - 2).ToList().Where(num => number % num == 0).Count();
            if (count > 0)
            {
                isPrime = false;
            }
        }
        return isPrime;
    }
}
