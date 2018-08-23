namespace EquipmentApi.Models
{
    public class Equipment
    {
        private string _id;
        private string _externalId;
        private string _equipmentTypeId;
        private int _meterReading;
        private string _typeExternalId;
        private string _typeDescription;

        public string Id { get => _id; set => _id = value; }
        public string ExternalId { get => _externalId; set => _externalId = value; }
        public string EquipmentTypeId { get => _equipmentTypeId; set => _equipmentTypeId = value; }
        public int MeterReading { get => _meterReading; set => _meterReading = value; }
        public string TypeExternalId { get => _typeExternalId; set => _typeExternalId = value; }
        public string TypeDescription { get => _typeDescription; set => _typeDescription = value; }

        public Equipment(string id, string externalId, string equipmentTypeId, int meterReading, string typeExternalId, string typeDescription)
        {
            Id = id;
            ExternalId = externalId;
            EquipmentTypeId = equipmentTypeId;
            MeterReading = meterReading;
            TypeExternalId = typeExternalId;
            TypeDescription = typeDescription;
        }

    }
}