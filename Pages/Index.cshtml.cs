using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using QuickBite.Data;
using QuickBite.Pages.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
namespace QuickBite.Pages
{
    public class IndexModel : PageModel //PageModel file is combined page controller & view model (i.e it processes info from a request & prepares a model for the view)
    {
        private readonly QuickBiteContext db;  
        public IndexModel(QuickBiteContext db) => this.db = db;//parameter's value provided by dependency injection system (i.e. 'construction injection')

        public List<Product> Products { get; set; } = new List<Product>();  
        public async Task OnGetAsync()
        {
            Products = await db.Products.ToListAsync();   
        }
    }
}
 