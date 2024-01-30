import React from 'react'

export default function Qn1() {
    const colors=["Red","Green","Yellow","Blue"]
  return (
    <div>
        <h1>Qn1</h1>
        <ol>
            {
                colors.map((item)=>{
                    return <li>{item}</li>
                })
            }
        </ol>
        <table border={1} className='table'>
            <thead>
                <tr>
                    <th>Colors</th>
                </tr>
            </thead>
            <tbody>
                {
                    colors.map((i)=>{
                        return(
                            <tr>
                            <td style={{backgroundColor:i}}>{i}</td>
                        </tr>
                        )
                    })
                }
            </tbody>
        </table>
    </div>
  )
}
