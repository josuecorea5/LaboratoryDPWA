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
    public class CreateCitasModel : PageModel
    {

        private readonly ICitasRepository _citasRepository;

        public CreateCitasModel(ICitasRepository citasRepository)
        {
            _citasRepository = citasRepository;
        }

        [BindProperty]
        public Citas Citas { get; set; }

        public void OnGet()
        { }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }
            _citasRepository.Insert(Citas);

            return RedirectToPage("./Citas");
        }
    }
}

