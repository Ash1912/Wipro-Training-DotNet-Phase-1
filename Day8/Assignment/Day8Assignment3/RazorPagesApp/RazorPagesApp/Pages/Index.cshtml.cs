using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Collections.Generic;
using RazorPagesApp.Models;

namespace RazorPagesApp.Pages
{
    public class IndexModel : PageModel
    {
        // Static list to store items (acts as temporary in-memory storage)
        public static List<Item> Items = new List<Item>();

        public List<Item> ItemList { get; private set; }

        public void OnGet()
        {
            ItemList = Items;
        }
    }
}
