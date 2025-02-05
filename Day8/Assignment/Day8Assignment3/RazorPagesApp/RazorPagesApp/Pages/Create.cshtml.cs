using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesApp.Models;

namespace RazorPagesApp.Pages
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Item NewItem { get; set; }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            IndexModel.Items.Add(NewItem); // Add item to the static list

            return RedirectToPage("Index"); // Redirect to list page
        }
    }
}
