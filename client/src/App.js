import React, { Component } from 'react';
import EquipmentList from './components/EquipmentList';
import './App.css';

class App extends Component {
  constructor(props){
    super(props);
    this.state = {};
  }

  componentDidMount() {
    fetch('https://localhost:5001/api/equipment')
    .then(res => res.json())
    .then(json => this.setState({equipment: json}))
  }

  render() {
    console.log(this.state.data);
    return (
      <div id="App">
        <EquipmentList props={this.state.equipment}/>
      </div>
    );
  }
}

export default App;
