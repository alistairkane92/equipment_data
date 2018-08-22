using System;
namespace EquipmentApi.Models
{
    public class EquipmentType
    {
        private string _id;
        private string _externalId;
        private string _description;

        public string Id { get => _id; set => _id = value; }
        public string ExternalId { get => _externalId; set => _externalId = value; }
        public string Description { get => _description; set => _description = value; }
    }
}
