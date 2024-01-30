import React from 'react'

export default function Qn1() {
    const colors=["Red","Green","Yellow","Blue"]
  return (
    <div>
        <ol>
            {
                colors.map((item)=>{
                    return <li style={{backgroundColor:item}}>{item}</li>
                })
            }
        </ol>
        <table border={1}>
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
