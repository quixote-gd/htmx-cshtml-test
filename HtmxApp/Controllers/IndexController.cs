using Microsoft.AspNetCore.Mvc;

namespace HtmxApp.Controllers;

public class IndexController : Controller
{
    private int count = 0;

    [HttpGet]
    [ActionName("IncrementCount")]
    public IActionResult IncrementCount()
    {
        count++;
        return Ok(count);
    }


}