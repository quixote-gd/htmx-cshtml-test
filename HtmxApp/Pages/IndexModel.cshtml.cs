using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace HtmxApp.Pages;

public class IndexModel : PageModel
{
        public int Count
        {
            get => HttpContext.Session.GetInt32("Count") ?? 0;
            set => HttpContext.Session.SetInt32("Count", value);
        }

        public void OnGet()
        {
            // Do not initialize the count here
            // The count will be fetched from TempData if it exists
            Console.WriteLine("OnGet executed | Count: " + Count);
        }

        public IActionResult OnGetIncrement()
        {
            // Increment the count
            Count = Count + 1;

            // Return the updated count as a partial view
            Console.WriteLine("OnGetIncrement executed | Count: " + Count);
            return Partial("_CountPartial", Count);
        }

        public IActionResult OnGetSearch(string userName, string email)
        {
            return Partial("_SearchPartial", userName);
        }
}

