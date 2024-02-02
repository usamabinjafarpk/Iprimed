import React, { useEffect, useState } from 'react'

export default function Timer() {
    const [count, setCount] = useState(0)
    useEffect(()=>{
        setCount((count)=>count+1)
    },[]);
  return (
    <div>Rendered {count} times</div>
  )
}
