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
    public class EquipmentController : Controller
    {
        [HttpGet]
        public String Get()
        {
            EquipmentRoot equipmentRoot = EquipmentRoot.ReadFromJson("EquipmentData.json");
            return JsonConvert.SerializeObject(equipmentRoot.SerialisedEquipment);
        }

        [HttpGet("{id}")]
        public String Get(string id)
        {
            EquipmentRoot equipmentRoot = EquipmentRoot.ReadFromJson("EquipmentData.json");
            return JsonConvert.SerializeObject(equipmentRoot.FindByUnitNumber(id));
        }
    }
}
