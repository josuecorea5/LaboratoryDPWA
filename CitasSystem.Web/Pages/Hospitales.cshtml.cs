using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CitasSystem.Data.Interfaces;
using CitasSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace CitasSystem.Web.Pages
{
    public class HospitalesModel : PageModel
    {
        private readonly IHospitalRepository _hospitalRepositoty;

        public HospitalesModel(IHospitalRepository hospitalRepositoty)
        {
            _hospitalRepositoty = hospitalRepositoty;
        }
        [BindProperty]
        public IEnumerable<Hospital> Hospitals { get; set; }
        public IActionResult OnGet()
        {
            Hospitals = _hospitalRepositoty.List();
            return Page();
        }
    }
}
