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
    
    [HttpPost("ValidateEmail")]
    [ActionName("ValidateEmail")]
    public IActionResult ValidateEmail(string email)
    {

        // this can easily be a partial view.

        var response = """
        <div hx-target="this" hx-swap="outerHTML" class="error">
        <label>Email Address</label>
        <input name="email" hx-post="/contact/email" hx-indicator="#ind" value="test@foo.com">
        <img id="ind" src="/img/bars.svg" class="htmx-indicator"/>
        <div class='error-message'>That email is already taken.  Please enter another email.</div>
        </div>
        """;
        return Ok(response);
    }


}