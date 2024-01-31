import React, { useState } from 'react'

export default function Demo3() {
    const [uname, setName] = useState("")
    const [names, setNames] = useState([])
    const save=(e)=>{
        setNames([...names,uname])
        e.preventDefault()
    }
  return (
    <div>
        <form onSubmit={save}>
        <h3>Enter Name</h3>
        <input type='text' onChange={(e)=>setName(e.target.value)}/>
        <button type='submit'>Submit</button>
        </form>
        <table className='table table-striped'>
            <tr>
                <th>Names</th>
            </tr>
            {
                names.map((n)=>{
                    return(
                        <tr>
                            <td>{n}</td>
                        </tr>
                    )
                })
            }
        </table>
    </div>
  )
}
