import React, { useState } from 'react'

export default function Car() {
    const [brand, setBrand] = useState("Ford")
    const [model, setModel] = useState("Mustang")
    const [year, setYear] = useState(1990)
    const [color, setColor] = useState("Black")
  return (
    <div>
        <h1>Brand: {brand}</h1>
        <p>It's a {color} {model} from {year}</p>
    </div>
  )
}
