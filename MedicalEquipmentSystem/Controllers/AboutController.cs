using Microsoft.AspNetCore.Mvc;

namespace MedicalEquipmentSystem.Controllers
{
    //about
    [Route("company/[controller]/[action]")]
    public class AboutController
    {
       
        public string Phone()
        {
            return "123";
        }

        
        public string Address()
        {
            return "USA";
        }
    }
}
