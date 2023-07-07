using EFAzureSQLDemo.Data;
using EFAzureSQLDemo.Data.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EFAzureSQLDemo.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        private readonly ApplicationDbContext _context;

        public IndexModel(ILogger<IndexModel> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public void OnGet()
        {
            
        }

        public Customer GetCustomerById(int Id) 
        {
            var result = _context.Customers.FirstOrDefault(x => x.Id == Id);
            return result;
        }
    }
}