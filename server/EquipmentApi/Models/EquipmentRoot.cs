﻿using System;
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

        public EquipmentRoot(){
        }

        public EquipmentRoot(string path){
            _equipment = new List<Equipment>();
            ReadTheJson(path);
        }

        public void ReadTheJson(string path){
            using (StreamReader reader = new StreamReader(path))
            {
                String json = reader.ReadToEnd();
                EquipmentRoot equipmentRoot = new EquipmentRoot();
                equipmentRoot = JsonConvert.DeserializeObject<EquipmentRoot>(json);
                SerialisedEquipment = equipmentRoot.SerialisedEquipment;
                EquipmentType = equipmentRoot.EquipmentType;
            }

            foreach (SerialisedEquipment equip in SerialisedEquipment)
            {
                foreach (EquipmentType type in EquipmentType)
                {
                    if (equip.EquipmentTypeId == type.Id)
                    {
                        Equipment newEquip = new Equipment(equip.Id, equip.ExternalId, equip.EquipmentTypeId, equip.MeterReading,
                                                           type.ExternalId, type.Description);
                        EquipmentList.Add(newEquip);
                    }
                }
            }

        }

        public List<Equipment> FindByUnitNumber(string id)
        {
            List<Equipment> result = new List<Equipment>();
            foreach (Equipment equipment in EquipmentList)
            {

                if (equipment.ExternalId == id)
                {
                    result.Add(equipment);
                }
            }
            return result;
        }

        public Equipment FindByEquipmentTypeId(string id)
        {
            foreach (Equipment equipment in EquipmentList)
            {

                if (equipment.TypeExternalId == id)
                {
                    return equipment;
                }
            }
            return null;
        }
    }
 }