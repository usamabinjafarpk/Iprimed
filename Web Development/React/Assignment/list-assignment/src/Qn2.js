import React from 'react'
const City=(props)=>{
    return <li>City is:{props.city}</li>
}


export default function Qn2() {
    const cities=["Trivandrum","Kochi","Malappuram"]
  return (
    <div>
        <h1>Qn2</h1>

        {
            cities.map((i)=>(
                <City city={i}/>
            ))
        }
    </div>
  )
}
