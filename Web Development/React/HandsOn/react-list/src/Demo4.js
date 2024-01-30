import React from 'react'
const Car=(props)=>{
    return <li>Car is:{props.model}</li>
}

export default function Demo4() {
    let cars=["BMW","Benz","Audi"]
  return (
    <div>
        {
            cars.map((c)=>(
                <Car model={c}/>
                ))
        }
    </div>
  )
}
