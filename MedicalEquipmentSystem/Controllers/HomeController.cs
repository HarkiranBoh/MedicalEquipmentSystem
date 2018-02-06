using Microsoft.AspNetCore.Mvc;
using MedicalEquipmentSystem.Models;
using MedicalEquipmentSystem.Services;
using MedicalEquipmentSystem.ViewModels;

namespace MedicalEquipmentSystem.Controllers
{
    public class HomeController : Controller
    {
        private IResturantData _resturnatData;
        private IGreeter  _greeter;

        public HomeController(IResturantData resturnatData, IGreeter greeter)
        {
            _resturnatData = resturnatData;
            _greeter = greeter;
        }

        public IActionResult Index()
        {
            var model = new HomeIndexViewModel();
            model.restaurant = _resturnatData.GetAll();
            model.CurrentMessage = _greeter.GetMessageOfTheDay();

            return View(model);
        }

        public IActionResult Details(int id)
        {
            var model = _resturnatData.Get(id);
            if(model == null)
            {
                return RedirectToAction(nameof(Index));
            }
            return View(model);
        }

    }
}
