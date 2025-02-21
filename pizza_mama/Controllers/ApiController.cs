using Microsoft.AspNetCore.Mvc;
using pizza_mama.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace pizza_mama.Controllers
{
    //[Route("api/[controller]")]
    [Route("[controller]")]
    [ApiController]
    //public class ApiController : ControllerBase
    public class ApiController : Controller
    {

        [HttpGet]
        [Route("GetPizzas")]
        public IActionResult GetPizzas()
        {
            var pizza = new Pizza() {  nom="pizza test", prix=8, vegetarienne=false, ingredients="tomate, oignons"};

            //return new string[] { "Pizza", "value2" };
            return Json(pizza);
        }



    }
}
