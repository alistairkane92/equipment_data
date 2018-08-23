import React, { Component } from 'react';
import EquipmentList from './components/EquipmentList';
import SearchBar from './components/SearchBar';
import './App.css';

class App extends Component {
  constructor(props){
    super(props);
    this.state = {
      query: ''
    };
  }

  componentDidMount() {
    fetch('https://localhost:5001/api/equipment')
    .then(res => res.json())
    .then(json => this.setState({equipment: json}))
  }

  handleSearchQuery = event => {
    this.setState({
      query: event.target.value
    })
  }

  render() {
    return (
      <div id="app">
        <input id="search-bar" type="text" placeholder="Search" onChange={this.handleSearchQuery}/>
        <EquipmentList equipment={this.state.equipment} query={this.state.query}/>
      </div>
    );
  }
}

export default App;
