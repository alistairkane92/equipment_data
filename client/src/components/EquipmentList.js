import EquipmentItem from './EquipmentItem';
import React from 'react';

const EquipmentList = ({equipment}) => {
  if (!equipment) return null;
  
  const equipmentItems = equipment.map(equip => {
    return <EquipmentItem props={equip}/>
  })

  return(
    <div>{equipmentItems}</div>
  )
};

export default EquipmentList;
