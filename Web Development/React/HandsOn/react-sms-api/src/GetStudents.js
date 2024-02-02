import axios from 'axios'
import React, { useEffect, useState } from 'react'

export default function GetStudents() {
    const [student, setStudent] = useState([])
    

useEffect(() => {
    axios
    .get("http://localhost:5066/api/Student/GetStudents")
    .then((response)=>{
        console.log(response.data);
        setStudent(response.data)
    })
    .catch((error)=>{
        console.log(error);
    })
}, [])

  return (
    <div className='container'>
      <table className='table table-striped'>
        <thead>
          <tr>
            <th>Id</th>
            <th>Name</th>
            <th>Class</th>
            <th>Section</th>
          </tr>
        </thead>
        <tbody>
          {
            student.map((s)=>{
              return(
                <tr key={s.id}>
                <td>{s.id}</td>
                <td>{s.name}</td>
                <td>{s.std}</td>
                <td>{s.section}</td>
              </tr>
              )
            })
          }
        </tbody>
      </table>
    </div>
  )
}
