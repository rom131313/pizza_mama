﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using pizza_mama.Data;
using pizza_mama.Models;

namespace pizza_mama.Pages.Admin.Pizzas
{
    public class DeleteModel : PageModel
    {
        private readonly pizza_mama.Data.DataContext _context;

        public DeleteModel(pizza_mama.Data.DataContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Pizza Pizza { get; set; } = default!;

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pizza = await _context.Pizzas.FirstOrDefaultAsync(m => m.PizzaId == id);

            if (pizza is not null)
            {
                Pizza = pizza;

                return Page();
            }

            return NotFound();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var pizza = await _context.Pizzas.FindAsync(id);
            if (pizza != null)
            {
                Pizza = pizza;
                _context.Pizzas.Remove(Pizza);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
