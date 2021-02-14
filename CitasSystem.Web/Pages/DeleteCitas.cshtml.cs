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
    public class DeleteCitasModel : PageModel
    {
        private readonly ICitasRepository _citasRepository;

        public DeleteCitasModel(ICitasRepository citasRepository)
        {
            _citasRepository = citasRepository;
        }

        [BindProperty]
        public Citas Citas { get; set; }
        public IActionResult OnGet(int id) 
        {
            Citas = _citasRepository.GetById(id);
            _citasRepository.Delete(Citas);
            return RedirectToPage("./Citas");
        }
    }
}
