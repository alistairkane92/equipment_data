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
        public string Get()
        {
            return JsonConvert.SerializeObject(equipmentRoot.EquipmentList);
        }

        [HttpGet("unit/{id}")]
        public string GetByUnitNumber(string id)
        {
            return JsonConvert.SerializeObject(equipmentRoot.FindByUnitNumber(id));
        }

        [HttpGet("type/{id}")]
        public string GetByTypeId(string id)
        {
            return JsonConvert.SerializeObject(equipmentRoot.FindByEquipmentTypeId(id));
        }
    }
}
