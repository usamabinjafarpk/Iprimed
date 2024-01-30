import React, { useState } from 'react'

export default function Count() {
    const [count, setCount] = useState(0)
  return (
    <div>
        <h1>Count:{count}</h1>
        <button onClick={()=>{
            setCount(count+1)
        }}>Click</button>
        <button onClick={()=>{
            setCount((prev)=>(prev+1))
        }}>Increment</button>
    </div>
  )
}
