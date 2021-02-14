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
    public class CreateHospitalModel : PageModel
    {
        private readonly IHospitalRepository _hospitalRepository;
        public CreateHospitalModel(IHospitalRepository hospitalRepository)
        {
            _hospitalRepository = hospitalRepository;
        }

        [BindProperty]
        public Hospital Hospital { get; set; }

        public void OnGet()
        { }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _hospitalRepository.Insert(Hospital);

            return RedirectToPage("./Hospitales");
        }
    }
}
