import React from 'react'

export default function Cricket() {
    // const Shot=()=>{
    //     alert("Good shot...")
    // }
    const Shot=(a)=>{
        alert("Good shot..."+a)
    }
  return (
    <div>
        {/* <button onClick={Shot}>Shot</button> */}
        <button onClick={()=>Shot("Amal")}>Shot</button>
        <button onClick={()=>Shot("Anna")}>Shot</button>
    </div>
  )
}
