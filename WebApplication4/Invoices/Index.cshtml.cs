using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebApplication4.Models;
using WebApplication4.NewFolder;

namespace WebApplication4.Invoices
{
    public class IndexModel : PageModel
    {
        private ApplicationDbContext context;

        public List<Invoice> invoicelist = new();  
        public IndexModel(ApplicationDbContext context)
        {
            this.context = context;
        }


        public void OnGet()
        {
            invoicelist = context.Invoices.OrderByDescending(i=>i.Id).ToList();
        }
    }
}
