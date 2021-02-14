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
    public class CreateDoctorsModel : PageModel
    {
        private readonly IDoctorsRepository _doctorsRepository;

        public CreateDoctorsModel(IDoctorsRepository doctorsRepository)
        {
            _doctorsRepository = doctorsRepository;
        }

        [BindProperty]
        public Doctors Doctors { get; set; }

        public void OnGet()
        { }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _doctorsRepository.Insert(Doctors);

            return RedirectToPage("./Doctores");
        }
    }
}
