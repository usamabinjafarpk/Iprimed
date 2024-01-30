import React, { useState } from 'react'

export default function Signup() {
    const [{name,email,address}, setUser] = useState({
        name:"Usama",
        email:"u@g.c",
        address:"TVM"
    })
    // function Update(){
    //     setUser({
    //         name:"Amal",
    //         Email:"a@g.c",
    //         address:address
    //     })
    // }
    const Update=()=>{
        setUser((prev)=>({
            ...prev,
            name:"Amal"
        }))
    }
  return (
    <div>
        <h1>Name:{name}</h1>
        <h2>Email:{email}</h2>
        <h2>Address:{address}</h2>
        <button onClick={Update}>Update</button>
    </div>
  )
}
