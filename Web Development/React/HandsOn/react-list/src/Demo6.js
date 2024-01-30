import React from 'react'

export default function Demo6() {
    let items=[
        {id:123,name:"Anna",age:10,std:9,sec:"A"},
        {id:234,name:"Amal",age:9,std:9,sec:"B"},
        {id:345,name:"Usama",age:10,std:9,sec:"C"}
    ]
  return (
    <div className='container'>
        <table className='table table-striped'>
            <thead>
                <tr>
                    <th>Id</th><th>Name</th><th>Age</th><th>Class</th><th>Section</th>
                </tr>
            </thead>
            <tbody>
                {
                    items.map((i)=>{
                        return(
                            <tr>
                            <td>{i.id}</td>
                            <td>{i.name}</td>
                            <td>{i.age}</td>
                            <td>{i.std}</td>
                            <td>{i.sec}</td>
                        </tr>
                        )
                    })
                }
            </tbody>
        </table>
    </div>
  )
}
