import React from 'react'

export default function Demo5() {
    let item={id:123,name:"Anna",age:10,std:9,sec:"A"}
  return (
    <div>
        <pre>
            Id:{item.id}
            Name:{item.name}
            Age:{item.age}
            Class:{item.std}
            Section:{item.sec}
        </pre>
    </div>
  )
}
