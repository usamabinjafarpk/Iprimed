import React, { useState } from 'react'

export default function Demo6() {
    let courses=[
        {id:1,cname:"React"},
        {id:2,cname:"C#"},
        {id:3,cname:"Js"},
        {id:4,cname:"CPP"}  
    ]
    let course={id:0,cname:""}
    const [crs, setCrs] = useState(course)
  return (
    <div className='container'>
        <label>Select Course</label>
        <div className='col'>
            <select
             onChange={(e)=>setCrs({id:e.target[e.target.selectedIndex].value,
                cname:e.target[e.target.selectedIndex].text})}
                >
                {
                    courses.map((s)=>{
                        return(
                        <option value={s.id}>{s.cname}</option>
                        )
                    })
                }
            </select>
        </div>
        <span className='text-primary'>Selected Course id:{crs.id} Course Name:{crs.cname}</span>

    </div>
  )
}
