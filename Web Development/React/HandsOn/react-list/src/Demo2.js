import React from 'react'

export default function Demo2() {
    const num=[1,2,3,4,5]
  return (
    <div>
        <ul>
            {
                num.map((item)=>{
                    return <li>{item}</li>
                })
            }
        </ul>
    </div>
  )
}
