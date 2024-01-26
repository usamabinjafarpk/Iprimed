import React from 'react'
import { useState } from 'react';

export default function Add() {
  const [first, setfirst] = useState(0)

  return (
    <div>
        <h1>{first}</h1>
      <button onClick={()=>{
        setfirst(first+1)
      }}>Click</button>
    </div>
  )
}
