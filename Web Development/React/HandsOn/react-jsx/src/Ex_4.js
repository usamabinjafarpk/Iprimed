import React from 'react'

export default function Ex_4() {
    let msg=""
    let x=5
    if(x>=0){
        msg="Positive"
    }
    else{
        msg="Negative"
    }
  return (
    <>
        <h3>{msg}</h3>
        <h3>{x>=0?"Positive":"Negative"}</h3>
    </>
  )
}
