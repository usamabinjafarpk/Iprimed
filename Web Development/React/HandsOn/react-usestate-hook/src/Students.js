import React, { useState } from 'react'

export default function Students() {
    const [student, setStudent] = useState({
        id:123,
        name:"Amal",
        std:5,
        sec:"A"
    })
  return (
    <div>
        <table border={100}>
            <thead>
                <tr>
                    <th>Id</th>
                    <th>Name</th>
                    <th>Class</th>
                    <th>Section</th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td>{student.id}</td>
                    <td>{student.name}</td>
                    <td>{student.std}</td>
                    <td>{student.sec}</td>
                </tr>
            </tbody>
        </table>
        <button onClick={()=>{
            setStudent((prev)=>({
                ...prev,
                std:6,
                sec:"B"
            }))
        }}>Update</button>
    </div>
  )
}
