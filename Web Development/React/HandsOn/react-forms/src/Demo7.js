import React, { useState } from 'react'

export default function Demo7() {
    let items=[
        {id:1,name:"Amal",std:1,sec:"A"},
        {id:2,name:"Anna",std:1,sec:"B"},
        {id:3,name:"Usama",std:1,sec:"A"}
    ]

    const [students, setStudents] = useState(items)
    const [id, setId] = useState()
    const [name, setName] = useState("")
    const [std, setStd] = useState("")
    const [sec, setSec] = useState("")

    function Add(e){
        setStudents([...students,
        {
            id:id,
            name:name,
            std:std,
            sec:sec
        }        ])
        e.preventDefault()
    }
  return (
    <div className='container'>
        <form onSubmit={Add}>
        <table border={2} className='table table-striped'>
            <thead className='table-dark'>
                <tr>
                    <th>Id</th>
                    <th>Name</th>
                    <th>Class</th>
                    <th>Section</th>
                </tr>
            </thead>
            <tbody>
                {
                    students.map((s)=>{
                        return(
                            <tr>
                                <td>{s.id}</td>
                                <td>{s.name}</td>
                                <td>{s.std}</td>
                                <td>{s.sec}</td>
                            </tr>
                        )
                    })
                }
                <tr>
                    <td>
                        <input type='number' placeholder='Enter the id' value={id} onChange={(e)=>setId(e.target.value)}/>
                    </td>
                    <td>
                        <input type='text' placeholder='Enter the name' value={name} onChange={(e)=>setName(e.target.value)}/>
                    </td>
                    <td>
                        <input type='number' placeholder='Enter the class' value={std} onChange={(e)=>setStd(e.target.value)}/>
                    </td>
                    <td>
                        <input type='text' placeholder='Enter the section' value={sec} onChange={(e)=>setSec(e.target.value)}/>
                    </td>
                </tr>
                <tr>
                    <td colSpan={4}>
                        <button className='btn btn-danger' type='submit'>Add</button>
                    </td>
                </tr>
            </tbody>
        </table>
        </form>
    </div>
  )
}
