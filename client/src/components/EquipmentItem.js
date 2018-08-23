import React from 'react';

const EquipmentItem = ({equip}) => (
    <div className="equipment-entry">
      <li className="equipment" id="equipment-id">{equip.ExternalId}</li>
      <li className="equipment">{equip.TypeExternalId}</li>
      <li className="equipment">{equip.TypeDescription}</li>
    </div>
);

export default EquipmentItem;
