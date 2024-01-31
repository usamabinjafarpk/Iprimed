import React, { useState } from 'react'

export default function Demo4() {
    let stds=[1,2,3,4,5]
    const [std, setStd] = useState(1)
  return (
    <div className='container'>
        <label>Select class</label>
        <div className='col'>
            <select value={std} onChange={(e)=>setStd(e.target.value)}>
                {
                    stds.map((s)=>{
                        return(
                        <option value={s}>{s}</option>
                        )
                    })
                }
            </select>
        </div>
        <span className='bg-primary'>Selected class is {std}</span>

    </div>
  )
}
