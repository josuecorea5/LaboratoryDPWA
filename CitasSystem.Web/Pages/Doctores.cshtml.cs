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
    public class DoctoresModel : PageModel
    {
        private readonly IDoctorsRepository _doctoresRepository;

        public DoctoresModel(IDoctorsRepository doctoresRepository)
        {
            _doctoresRepository = doctoresRepository;
        }

        [BindProperty]
        public IEnumerable<Doctors> Doctors { get; set; }

        public IActionResult OnGet()
        {
            Doctors = _doctoresRepository.List();
            return Page();
        }
    }
}
