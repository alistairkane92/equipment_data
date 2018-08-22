using System;
namespace EquipmentApi.Models
{
    public class SerialisedEquipment
    {
        private string _id;
        private string _externalId;
        private string _equipmentTypeId;
        private int _meterReading;

        string Id { get => _id; set => _id = value; }
        string ExternalId { get => _externalId; set => _externalId = value; }
        string EquipmentTypeId { get => _equipmentTypeId; set => _equipmentTypeId = value; }
        int MeterReading { get => _meterReading; set => _meterReading = value; }
    }
}
