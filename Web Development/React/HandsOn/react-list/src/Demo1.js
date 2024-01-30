import React from 'react'

export default function Demo1() {
    const Countries=['IND','China','USA']
    let list=Countries.map((i)=>{
        return <li>{i}</li>
    })
  return (
    <div>
        <ol>
        {
            Countries.map((item)=>{
                return <li>{item}</li>
            })
        }
        </ol>
        <hr/>
        <ul>{list}</ul>
        
    </div>
  )
}
