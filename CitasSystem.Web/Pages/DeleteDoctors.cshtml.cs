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
    public class DeleteDoctorsModel : PageModel
    {
        private readonly IDoctorsRepository _doctorsRepository;

        public DeleteDoctorsModel(IDoctorsRepository doctorsRepository)
        {
            _doctorsRepository = doctorsRepository;
        }
        [BindProperty]
        public Doctors Doctors { get; set; }
        public IActionResult OnGet(int id)
        {
            Doctors = _doctorsRepository.GetById(id);
            _doctorsRepository.Delete(Doctors);
            return RedirectToPage("./Doctores");
        }
     
    }
}
