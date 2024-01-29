import React from 'react'

export default function Garage(props) {
    let cars=props.cars
  return (
    <div>
        Garage
        {cars.length>0?<h1>You have {cars.length} car in garage</h1>:
        <h1>No cars in garage</h1>}
    </div>
  )
}
