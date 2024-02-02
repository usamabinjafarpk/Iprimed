import React, { useEffect, useState } from 'react'

export default function Demo2() {
    const [count, setCount] = useState(0)
    useEffect(()=>{
        setTimeout(()=>{
            setCount((prev)=>prev+1)
        },100)
    })
  return (
    <div>
        <h1>{count}</h1>
    </div>
  )
}
