import React, { useEffect, useState } from 'react'

export default function Demo1() {
    const [count, setcount] = useState(0)
    const [first, setfirst] = useState(0)
    useEffect(()=>{
        setfirst(count*2)
    },[count])
  return (
    <div>
        <div>{count}</div>
        <button onClick={()=>{
            setcount((prev)=>prev+1)
        }}>+</button>
        <h1>Calc:{first}</h1>
    </div>
  )
}
