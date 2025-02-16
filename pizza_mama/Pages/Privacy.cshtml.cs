using Microsoft.AspNetCore.Mvc.RazorPages;
using pizza_mama.Data;
using pizza_mama.Models;

namespace pizza_mama.Pages
{
    public class PrivacyModel : PageModel
    {
        private readonly DataContext _dataContext;

        public string Message { get; set; } = "Aucune action effectuée."; // Variable pour stocker le message

        public PrivacyModel(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public void OnGet()
        {
            //var pizza = new Pizza
            //{
            //    nom = "PizzaTest",
            //    prix = 5.0f,
            //    vegetarienne = false,
            //    ingredients = "Tomate, Fromage"
            //};

            //_dataContext.Pizzas.Add(pizza);
            //int changes = _dataContext.SaveChanges();

            //if (changes > 0)
            //{
            //    Message = "✅ Pizza ajoutée avec succès !";
            //}
            //else
            //{
            //    Message = "❌ ERREUR : Aucune pizza ajoutée !";
            //}
        }
    }
}
