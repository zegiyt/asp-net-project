using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace First_Project.Pages.Customers
{
    public class customer : PageModel
    {
        private readonly ILogger<customer> _logger;

        public customer(ILogger<customer> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}