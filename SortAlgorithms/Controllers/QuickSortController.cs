using Microsoft.AspNetCore.Mvc;

namespace SortAlgorithms.Controllers;

[ApiController]
[Route("[controller]")]
public class QuickSortController : ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromQuery]List<int> numbers)
    {
        var result = string.Join(", ", QuickSort.Sort(numbers, 0, numbers.Count -1));
        return Ok(result);
    }
}