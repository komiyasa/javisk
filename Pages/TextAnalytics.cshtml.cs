using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace KomiyasaWebApp.Pages
{
    public class TextAnalyticsModel : PageModel
    {
        //Text Analytics で処理をするプロパティを
        public string inputText { get; set; }
        public int Answer { get; set; }

        public IActionResult OnGet()
        {
            return Page();
        }
    }
}

    