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
    public class CitasModel : PageModel
    {
        private readonly ICitasRepository _citasRepository;

        public CitasModel(ICitasRepository citasRepository)
        {
            _citasRepository = citasRepository;
        }
        [BindProperty]
        public IEnumerable<Citas> Citas  { get; set; }

        public IActionResult OnGet()
        {
            Citas = _citasRepository.List();
            return Page();
        }
    }
}
