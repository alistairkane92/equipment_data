using System;
namespace EquipmentApi.Models
{
    public class SerialisedEquipment
    {
        private string _id;
        private string _externalId;
        private string _equipmentTypeId;
        private int _meterReading;

        public string Id { get => _id; set => _id = value; }
        public string ExternalId { get => _externalId; set => _externalId = value; }
        public string EquipmentTypeId { get => _equipmentTypeId; set => _equipmentTypeId = value; }
        public int MeterReading { get => _meterReading; set => _meterReading = value; }
    }
}
