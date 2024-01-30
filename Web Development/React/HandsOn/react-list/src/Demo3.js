import React from 'react'

export default function Demo3() {
    const employees=["Anna","Amal","Usama"]
  return (
    <div>
        <table className='table table-striped'>
            <thead className='table-danger'>
                <tr>
                    <th>Employee</th>
                </tr>
            </thead>
            <tbody>
                {
                    employees.map((emp)=>{
                        return (
                            <tr>
                                <td>{emp}</td>
                            </tr>
                        )
                    })
                }
            </tbody>
        </table>
    </div>
  )
}
