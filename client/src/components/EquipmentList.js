import EquipmentItem from './EquipmentItem';
import React, { Component } from 'react';

class EquipmentList extends Component {
  constructor(props){
    super(props);
    this.state = {
      equipmentRender: this.props.equipment || []
    }
  }

  componentDidUpdate(){
    if (this.props.query.length > 5){
      let url = `https://localhost:5001/api/equipment/unit/${this.props.query}`
      fetch(url)
      .then(res => res.json())
      .then(json => this.setState({equipmentRender: json}))
    }
  }

  createRenderObjects = () => {
    if (this.props.query.length < 6 || this.state.equipmentRender.length < 1){
      return this.props.equipment.map(equip => {
        return <EquipmentItem equip={equip} key={equip.ExternalId}/>
      })
    }

    if (this.state.equipmentRender.length > 0){
      return this.state.equipmentRender.map(equip => {
        return <EquipmentItem equip={equip} key={equip.ExternalId}/>
      })
    }
  }

  render(){
    if (!this.props.equipment) return null;
    let renderableEquipment = this.createRenderObjects();

    return(
      <ul id="equipment-list">
        {renderableEquipment}
      </ul>
    )
  }

};

export default EquipmentList;
