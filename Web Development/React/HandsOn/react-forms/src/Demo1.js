import React, { useRef, useState } from 'react'

export default function Demo1() {
    const nref=useRef()
    let names=["abc","cds"]
    console.log(nref);
    const [name, setName] = useState([])
    const submitForm=()=>{
        setName(nref.current.value)
        names.push(name)

        console.log(names);
    }
    
  return (
    <div className='container'>
            <table className='table'>
                <tr>
                    <td>Enter the name</td>
                </tr>
                <tr>
                    <td colSpan={2}>
                        <input type='text' ref={nref}/>
                    </td>
                </tr>
                
                <tr>
                    <td colSpan={2}>
                        <button onClick={submitForm} className='btn btn-primary'>Submit</button>
                        </td>
                </tr>
            </table>
            <hr/>
            <table>
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
