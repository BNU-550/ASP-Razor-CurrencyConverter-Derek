using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RazorCurrencyConverter.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public string FullName { get; set; }

        private readonly ILogger<IndexModel> _logger;

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
            FullName = "Derek Peacock";
        }

        public void OnPost()
        {
            if(String.IsNullOrWhiteSpace(FullName))
            {
                ViewData["Message"] = "Name is missing!";
                FullName = "Anonymous";
            }
            else
            {
                ViewData["Message"] = "Name is Registered!";
                // Rgister the user
            }
        }

    }
}
