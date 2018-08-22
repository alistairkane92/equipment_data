import EquipmentItem from './EquipmentItem';
import React from 'react';

const EquipmentList = ({equipment}) => {
  console.log("equipmentList", equipment);
  if (!equipment) return null;

  const equipmentItems = equipment.map(equip => {
    return <EquipmentItem equip={equip}/>
  })

  console.log('equipmentItems', equipmentItems);

  return(
    <div>{equipmentItems}</div>
  )
};

export default EquipmentList;
