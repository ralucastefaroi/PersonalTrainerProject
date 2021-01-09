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
    public class IndexModel : PageModel
    {
        private readonly PersonalTrainerProject.Data.PersonalTrainerProjectContext _context;

        public IndexModel(PersonalTrainerProject.Data.PersonalTrainerProjectContext context)
        {
            _context = context;
        }

        public IList<Supliment> Supliment { get;set; }

        public async Task OnGetAsync()
        {
            Supliment = await _context.Supliment.ToListAsync();
        }
    }
}
