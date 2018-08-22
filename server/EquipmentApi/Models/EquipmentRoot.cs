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
        private List<Equipment> _equipment;

        public List<SerialisedEquipment> SerialisedEquipment { get => _serialisedEquipment; set => _serialisedEquipment = value; }
        public List<EquipmentType> EquipmentType { get => _equipmentType; set => _equipmentType = value; }
        public List<Equipment> EquipmentList { get => _equipment; set => _equipment = value; }

        public EquipmentRoot(string path){
            ReadFromJson(path);
        }

        public void ReadFromJson(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                String json = reader.ReadToEnd();
                EquipmentRoot equipmentRoot = JsonConvert.DeserializeObject<EquipmentRoot>(json);
                SerialisedEquipment = equipmentRoot.SerialisedEquipment;
                EquipmentType = equipmentRoot.EquipmentType;
            }

            foreach(SerialisedEquipment equip in SerialisedEquipment){
                foreach(EquipmentType type in EquipmentType){
                    if (equip.EquipmentTypeId == type.Id){
                        EquipmentList.Add(
                            new Equipment(equip.Id, equip.ExternalId, equip.EquipmentTypeId, equip.MeterReading, 
                                          type.Id, type.ExternalId, type.Description));
                    }
                }
            }
        }

        public Equipment FindByUnitNumber(string id)
        {
            foreach (Equipment equipment in EquipmentList)
            {

                if (equipment.Id == id)
                {
                    return equipment;
                }
            }
            return null;
        }

        public Equipment FindByEquipmentTypeId(string id)
        {
            foreach (Equipment equipment in EquipmentList)
            {

                if (equipment.EquipmentTypeId == id)
                {
                    return equipment;
                }
            }
            return null;
        }
    }
 }