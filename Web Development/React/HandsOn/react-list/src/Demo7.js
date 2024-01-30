import React from 'react'

export default function Demo7(props) {
  return (
    <div>
        <u>
            {
                props.cities.map((c)=>{
                    return<li>{c}</li>
                })
            }
        </u>
    </div>
  )
}
