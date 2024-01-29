import React, { Component} from "react";
 
class Car extends Component {
    render() {
        return (
            <div>
                <h2 style={{color: this.props.color }}>
                    I am Car!!! with {this.props.color} color
                </h2>
            </div>
        );
    }
}
class Garage extends Component {
    render() {
        return (
            <>
                <Car color="red"></Car>
                <Car color="Green"></Car>
            </>
        );
    }
}
export default Garage;