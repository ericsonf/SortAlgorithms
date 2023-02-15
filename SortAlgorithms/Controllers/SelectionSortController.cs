using Microsoft.AspNetCore.Mvc;

namespace SortAlgorithms.Controllers;

[ApiController]
[Route("[controller]")]
public class SelectionSortController : ControllerBase
{
    [HttpGet]
    public IActionResult Get([FromQuery]List<int> numbers)
    {
        var result = string.Join(", ", SelectionSort.Sort(numbers));
        return Ok(result);
    }
}