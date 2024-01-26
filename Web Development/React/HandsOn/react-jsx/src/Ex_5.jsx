import React from 'react'

export default function Ex_5() {
    let msg=""
    let x=-1
    if(x>=0) msg="positive"
    else msg="Negative"
    const myElement=<h1>{msg}</h1>
    const myElement1=<h1>{(x>=0)?"+ve":"-ve"}</h1>
  return (
    <>
        {myElement}
        {myElement1}
    </>
    )
}
