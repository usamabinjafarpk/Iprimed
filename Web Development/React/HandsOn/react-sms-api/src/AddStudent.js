import { React, useState } from "react";
import axios from "axios";
const AddStudent = () => {
  const [id, setId] = useState("");
  const [name, setName] = useState("");
  const [std, setStd] = useState("");
  const [section, setSection] = useState("");
  const [all,setAll]=useState("")
  const Save = () => {
    let student = {
      id: id,
      name: name,
      std: std,
      section: section,
    };
    axios
      .post("http://localhost:5066/api/Student/AddStudent", student)
      .then((response) => {
        console.log(response.data);
      })
      .catch((error) => console.log(error));
  };
  const Search = () => {
    axios
      .get("http://localhost:5066/api/Student/GetStudent/" + id)
      .then((response) => {
        console.log(response.data);
        setName(response.data.name);
        setStd(response.data.std);
        setSection(response.data.section);
      })
      .catch((error) => console.log(error));
  };
  const Edit = () => {
    let student = {
      id: id,
      name: name,
      std: std,
      section: section,
    };
    axios
      .put("http://localhost:5066/api/Student/EditStudent", student)
      .then((response) => {
        console.log(response.data);
      })
      .catch((error) => console.log(error));
  };
  const Delete = () => {
    axios
      .delete("http://localhost:5066/api/Student/DeleteStudent/" + id)
      .then((response) => {
        console.log(response.data);
      })
      .catch((error) => console.log(error));
  };
  const GetAll=()=>{
    axios
    .get("http://localhost:5066/api/Student/GetStudents")
    .then((res)=>{
        console.log(res.data);
        setAll(res.data)
    })
  }
  return (
    <div className="container">
      <form onSubmit={Save}>
        <table className="table">
          <tbody>
            <tr>
              <td>Id</td>
              <td>
                <input
                  type="text"
                  value={id}
                  onChange={(e) => setId(e.target.value)}
                />
              </td>
            </tr>
            <tr>
              <td>Name</td>
              <td>
                <input
                  type="text"
                  value={name}
                  onChange={(e) => setName(e.target.value)}
                />
              </td>
            </tr>
            <tr>
              <td>Class</td>
              <td>
                <input
                  type="text"
                  value={std}
                  onChange={(e) => setStd(e.target.value)}
                />
              </td>
            </tr>
            <tr>
              <td>Section</td>
              <td>
                <input
                  type="text"
                  value={section}
                  onChange={(e) => setSection(e.target.value)}
                />
              </td>
            </tr>
            <tr>
              <td colSpan={2}>
                <button type="submit">Add</button>
                <button type="button" onClick={Search}>
                  Search
                </button>
                <button type="button" onClick={Edit}>
                  Edit
                </button>
                <button type="button" onClick={Delete}>
                  Delete
                </button>
                <button onClick={GetAll}>Get All</button>
              </td>
            </tr>
          </tbody>
        </table>
        
      </form>
      {/* <table className='table table-striped'>
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
            all.map((s)=>{
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
      </table> */}
    </div>
  );
};
export default AddStudent;
 
