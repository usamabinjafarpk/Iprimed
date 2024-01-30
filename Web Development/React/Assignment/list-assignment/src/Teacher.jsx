import React, { useState } from 'react'

export default function Teacher() {
    const [teacher, setTeacher] = useState({
        teacherId:123,
        teacherName:"Anna",
        subject:["Maths","English"],
        std:10
    })
  return (
    <div>
        <table border={1} className='table table-success table-striped'>
            <thead>
                <tr>
                    <th>Teacher Id</th>
                    <th>Name</th>
                    <th>Subject</th>
                    <th>Class</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>{teacher.teacherId}</td>
                    <td>{teacher.teacherName}</td>
                    <td>{teacher.subject}</td>
                    <td>{teacher.std}</td>
                </tr>
                
            </tbody>
        </table>
        <button onClick={()=>{
            setTeacher((prev)=>({
                ...prev,
                std:9
            }))
        }}>Update</button>
    </div>
  )
}
