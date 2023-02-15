using Microsoft.AspNetCore.Mvc;

namespace SortAlgorithms.Controllers;

[ApiController]
[Route("[controller]")]
public class BubbleSortController : ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromQuery]List<int> numbers)
    {
        var result = string.Join(", ", BubbleSort.Sort(numbers));
        return Ok(result);
    }
}