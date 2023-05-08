using Microsoft.AspNetCore.Mvc;
using p138relation.Models;

namespace p138relation.Controllers
{
    public class CarController : Controller

    {

        private readonly List<car> _marka;
        
        public CarController()
        {
            _marka = new List<car>
            {
                new car {Id=1,price=20000,ModelId=1},
                
            };
        }


        public IActionResult Index(int? id)
        {
        


            return View();
        }


    }
}
