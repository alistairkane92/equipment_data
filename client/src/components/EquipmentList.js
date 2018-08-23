import EquipmentItem from './EquipmentItem';
import React from 'react';

const EquipmentList = ({equipment}) => {
  if (!equipment) return null;

  const equipmentItems = equipment.map(equip => {
    return <EquipmentItem equip={equip} key={equip.ExternalId}/>
  })

  return(
    <ul id="equipment-list">
      {equipmentItems}
    </ul>
  )
};

export default EquipmentList;
