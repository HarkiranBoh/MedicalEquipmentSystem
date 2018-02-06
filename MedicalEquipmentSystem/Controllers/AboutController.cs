using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

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
