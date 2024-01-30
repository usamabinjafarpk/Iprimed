import React, { useState } from 'react'

export default function Favoritecolor() {
    const [color, setColor] = useState("Green")
  return (
    <div>
        <h1 style={{color:color}}>Favorite color is:{color}</h1>
        <button onClick={()=>{
            setColor("Red")
        }}>Change</button>
    </div>
  )
}
