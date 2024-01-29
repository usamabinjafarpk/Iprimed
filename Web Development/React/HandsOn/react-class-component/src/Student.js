import React from "react";
class Student extends React.Component{
    constructor(props){
        super(props)
        this.state={
            rollno:1,
            name:"Usama",
            std:4,
            section:'A'
        }
    }
    changeState=()=>{
        this.setState({
            section:"B",
            rollno:this.state.rollno+1
        })
    }
    render(){
        return(
            <>
                <h1>Iam {this.state.name}</h1>
                <h2>rollno:{this.state.rollno}</h2>
                <h2>Studied in {this.state.std} {this.state.section} class</h2>
                <button onClick={this.changeState}>Click me</button>
            </>
        )
    }
}
export default Student