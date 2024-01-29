import React, { memo } from 'react'

const Football = memo(() => {
    const Shoot=(a,b)=>{
        alert("Great "+a)
        alert(b.type)
    }
  return (
    <div>
        <button onClick={(event)=>Shoot("Amal",event)}>Click</button>
    </div>
  )
})

export default Football