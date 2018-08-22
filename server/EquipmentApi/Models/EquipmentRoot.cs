using System;
using System.Collections.Generic;
using System.IO;
using Newtonsoft.Json;

namespace EquipmentApi.Models
{
    public class EquipmentRoot
    {
        private List<SerialisedEquipment> _serialisedEquipment;
        private List<EquipmentType> _equipmentType;

        public List<SerialisedEquipment> SerialisedEquipment { get => _serialisedEquipment; set => _serialisedEquipment = value; }
        public List<EquipmentType> EquipmentType { get => _equipmentType; set => _equipmentType = value; }

        public static EquipmentRoot ReadFromJson(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                String json = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<EquipmentRoot>(json);
            }
        }
    }
}