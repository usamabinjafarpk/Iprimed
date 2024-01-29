import React, { Component } from 'react'

export default class Count extends Component {
    constructor(props){
        super(props);
        this.state={
            count:0
        }
    }
  render() {
    return (
      <div>
        <h1>Count:{this.state.count}</h1>
        <button onClick={()=>{
            this.setState({count:this.state.count+1})
        }}>Click</button>
      </div>
    )
  }
}
