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
    public class EditCitaModel : PageModel
    {
        private readonly ICitasRepository _citasRepository;

        public EditCitaModel(ICitasRepository citasRepository)
        {
            _citasRepository = citasRepository;
        }

        [BindProperty]
        public Citas Citas { get; set; }

        public IActionResult OnGet(int id)
        {
            Citas = _citasRepository.GetById(id);
            if (Citas == null)
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
            var citasToUpdate = _citasRepository.GetById(id);
            if (citasToUpdate == null)
            {
                return NotFound();
            }
            citasToUpdate.IdCita = Citas.IdCita;
            citasToUpdate.Name = Citas.Name;
            citasToUpdate.LastName = Citas.LastName;
            citasToUpdate.Hour = Citas.Hour;
            _citasRepository.Update(citasToUpdate);

            return RedirectToPage("./Citas");
        }
    }
}
