using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using PersonalTrainerProject.Data;
using PersonalTrainerProject.Models;

namespace PersonalTrainerProject.Pages.Suplimente
{
    public class CreateModel : PageModel
    {
        private readonly PersonalTrainerProject.Data.PersonalTrainerProjectContext _context;

        public CreateModel(PersonalTrainerProject.Data.PersonalTrainerProjectContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Supliment Supliment { get; set; }

        // To protect from overposting attacks, enable the specific properties you want to bind to, for
        // more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Supliment.Add(Supliment);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
