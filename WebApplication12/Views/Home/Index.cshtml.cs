using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using WebApplication12.Models;

namespace WebApplication12.Views.Home
{
    public class IndexModel : PageModel
    {

        [BindProperty(SupportsGet = true)]
        public string City { get; set; }

        
        public void OnGet()
        {
            if(string.IsNullOrWhiteSpace(City))
            {
                City = "aboba";
            }
        }
    }
}
