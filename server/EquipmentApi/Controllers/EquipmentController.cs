using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EquipmentApi.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace EquipmentApi.Controllers
{
    [Route("api/[controller]")]
    public class EquipmentController : ControllerBase
    {
        protected EquipmentRoot equipmentRoot = new EquipmentRoot("EquipmentData.json");

        [HttpGet]
        public String Get()
        {
            return JsonConvert.SerializeObject(equipmentRoot.EquipmentList);
        }

        [HttpGet("unit/{id}")]
        public String GetByUnitNumber(string id)
        {
            return JsonConvert.SerializeObject(equipmentRoot.FindByUnitNumber(id));
        }

        [HttpGet("type/{id}")]
        public String GetByTypeId(string id)
        {
            return JsonConvert.SerializeObject(equipmentRoot.FindByEquipmentTypeId(id));
        }
    }
}
