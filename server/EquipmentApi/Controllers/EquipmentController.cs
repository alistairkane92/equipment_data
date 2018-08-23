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
        [HttpGet]
        public String Get()
        {
            EquipmentRoot equipmentRoot = new EquipmentRoot("EquipmentData.json");
            List<Equipment> test = equipmentRoot.EquipmentList;
            return JsonConvert.SerializeObject(equipmentRoot.EquipmentList);
        }

        [HttpGet("{id}")]
        public String Get(string id)
        {
            EquipmentRoot equipmentRoot = new EquipmentRoot("EquipmentData.json");
            return JsonConvert.SerializeObject(equipmentRoot.FindByUnitNumber(id));
        }

        [HttpGet("unit/{id}")]
        public String GetByUnitNumber(string id)
        {
            EquipmentRoot equipmentRoot = new EquipmentRoot("EquipmentData.json");
            return JsonConvert.SerializeObject(equipmentRoot.FindByUnitNumber(id));
        }

        [HttpGet("type/{id}")]
        public String GetByTypeId(string id)
        {
            EquipmentRoot equipmentRoot = new EquipmentRoot("EquipmentData.json");
            return JsonConvert.SerializeObject(equipmentRoot.FindByEquipmentTypeId(id));
        }
    }
}
