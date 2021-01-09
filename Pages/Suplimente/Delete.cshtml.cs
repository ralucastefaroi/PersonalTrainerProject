using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using PersonalTrainerProject.Data;
using PersonalTrainerProject.Models;

namespace PersonalTrainerProject.Pages.Suplimente
{
    public class DeleteModel : PageModel
    {
        private readonly PersonalTrainerProject.Data.PersonalTrainerProjectContext _context;

        public DeleteModel(PersonalTrainerProject.Data.PersonalTrainerProjectContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Supliment Supliment { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Supliment = await _context.Supliment.FirstOrDefaultAsync(m => m.ID == id);

            if (Supliment == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Supliment = await _context.Supliment.FindAsync(id);

            if (Supliment != null)
            {
                _context.Supliment.Remove(Supliment);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
