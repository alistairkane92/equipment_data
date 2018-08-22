using System;
using System.Collections.Generic;

namespace EquipmentApi.Models
{
    public class EquipmentRoot
    {
        private List<SerialisedEquipment> _serialisedEquipment;
        private List<EquipmentType> _equipmentType;

        public List<SerialisedEquipment> SerialisedEquipment { get => _serialisedEquipment; set => _serialisedEquipment = value; }
        public List<EquipmentType> EquipmentType { get => _equipmentType; set => _equipmentType = value; }
    }
}
