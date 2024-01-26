import Student from "./Student"

const ClassRoom=()=>{
    let a=[{name:"Amal" ,age:"22", std:"10", section:"A"},
    {name:"Amal" ,age:"22", std:"10", section:"A"}
    ]
    return(
        <table className="table table-stripped">
            <thead>
                <tr>
                    <th>Name</th>
                    <th>Age</th>
                    <th>Class</th>
                    <th>Section</th>
                </tr>
            </thead>
            <tbody>
                <Student name="Amal" age="22" std="10" section="A"/>
                <Student name="Anna" age="22" std="9" section="B"/>
                <Student name="Usama" age="22" std="10" section="A"/>
            </tbody>
        </table>
    )
}
export default ClassRoom