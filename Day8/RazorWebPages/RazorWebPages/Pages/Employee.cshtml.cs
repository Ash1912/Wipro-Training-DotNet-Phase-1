using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using WiproRazorWebPagesDemo.Models;

namespace WiproRazorWebPagesDemo.Pages
{
    public class EmployeeModel : PageModel
    {
        [BindProperty]
        public Employee emps { get; set; } = new Employee();
        public void OnGet()
        {
            //This method will be called when the page is loaded
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            ViewData["Message"] = $"Hello {emps.Name}";
            return Page();
        }
    }
}
