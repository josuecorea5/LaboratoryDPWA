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
    public class DeleteHospitalsModel : PageModel
    {
        private readonly IHospitalRepository _hospitalRepository;

        public DeleteHospitalsModel(IHospitalRepository hospitalRepository)
        {
            _hospitalRepository = hospitalRepository;
        }

        [BindProperty]
        public Hospital Hospital { get; set; }
        public IActionResult OnGet(int id)
        {
            Hospital = _hospitalRepository.GetById(id);
            _hospitalRepository.Delete(Hospital);
            return RedirectToPage("./Hospitales");
        }
    }
}
