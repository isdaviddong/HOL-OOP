using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApp.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;

        public float BmiResult = 0;

        [BindProperty]
        public int fieldHeight { get; set; }
        [BindProperty]
        public int fieldWeight { get; set; }

        public IndexModel(ILogger<IndexModel> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
        public void OnPostCalculate()
        {
            //身高轉公尺
            float h = (float)fieldHeight / 100;

            //計算BMI
            BmiResult = fieldWeight / (h * h);
        }
    }
}
