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
    public class EditDoctorsModel : PageModel
    {
        private readonly IDoctorsRepository _doctorsRepository;

        public EditDoctorsModel(IDoctorsRepository doctorsRepository)
        {
            _doctorsRepository = doctorsRepository;
        }
        [BindProperty]
        public Doctors Doctors { get; set; }

        public IActionResult OnGet(int id)
        {
            Doctors = _doctorsRepository.GetById(id);
            if(Doctors == null)
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
            var doctorsToUpdate = _doctorsRepository.GetById(id);
            if(doctorsToUpdate == null){
                return NotFound();
            }
            doctorsToUpdate.CodeNumber = Doctors.CodeNumber;
            doctorsToUpdate.Name = Doctors.Name;
            doctorsToUpdate.LastName = Doctors.LastName;
            doctorsToUpdate.Specialty = Doctors.Specialty;
            doctorsToUpdate.Schedule = Doctors.Schedule;
            _doctorsRepository.Update(doctorsToUpdate);

            return RedirectToPage("./Doctores");
        }
    }





}





