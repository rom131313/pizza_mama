using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using pizza_mama.Data;
using pizza_mama.Models;

namespace pizza_mama.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly ILogger<PrivacyModel> _logger;
        DataContext dataContext;

        public PrivacyModel(ILogger<PrivacyModel> logger, DataContext datacontext)
        {
            _logger = logger;
            this.dataContext = datacontext;
        }

        public void OnGet()
        {
            var pizza = new Pizza() { nom = "PizzaTest", prix = 5 };
            dataContext.Pizzas.Add(pizza);
            dataContext.SaveChanges();

            // Vérifie si l'insertion a réussi
            var pizzas = dataContext.Pizzas.ToList();
            Console.WriteLine($"Nombre de pizzas en base : {pizzas.Count}");

        }
    }

}
