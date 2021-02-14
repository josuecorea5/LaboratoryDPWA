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
    public class EditHospitalModel : PageModel
    {
        private readonly IHospitalRepository _hospitalRepository;

        public EditHospitalModel(IHospitalRepository hospitalRepository)
        {
            _hospitalRepository = hospitalRepository;
        }
        [BindProperty]
        public Hospital Hospital { get; set; }

        public IActionResult OnGet(int id)
        {
            Hospital = _hospitalRepository.GetById(id);
            if (Hospital == null)
            {
                return NotFound();
            }
            return Page();
        }
        public IActionResult OnPost(int id)
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            var hospitalsToUpdate = _hospitalRepository.GetById(id);
            if (hospitalsToUpdate == null)
            {
                return NotFound();
            }
            hospitalsToUpdate.CodeHospital = Hospital.CodeHospital;
            hospitalsToUpdate.Name = Hospital.Name;
            hospitalsToUpdate.Address = Hospital.Address;
            hospitalsToUpdate.Cellphone = Hospital.Cellphone;
            _hospitalRepository.Update(hospitalsToUpdate);

            return RedirectToPage("./Hospitales");
        }
    }
}
