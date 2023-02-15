using Microsoft.AspNetCore.Mvc;

namespace SortAlgorithms.Controllers;

[ApiController]
[Route("[controller]")]
public class InsertionSortController : ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromQuery]List<int> numbers)
    {
        var result = string.Join(", ", InsertionSort.Sort(numbers));
        return Ok(result);
    }
}