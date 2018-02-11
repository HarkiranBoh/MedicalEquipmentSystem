using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MedicalEquipmentSystem.Services;
using MedicalEquipmentSystem.ViewModels;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MedicalEquipmentSystem.Controllers
{
    public class ProductController : Controller
    {
        private IProductData _productData;
        private IGreeter _greeter;

        public ProductController(IProductData productData, IGreeter greeter)
        {
            _productData = productData;
            _greeter = greeter;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = new ProductViewModel();
            model.product = _productData.GetAll();
            model.CurrentMessage = _greeter.GetMessageOfTheDay();

            return View(model);
           
        }
    }
}
