import React, { useState } from 'react';
 
const Ex1 = () => {
  const [inputValue, setInputValue] = useState('');
  const [tableData, setTableData] = useState([]);
 
  const handleInputChange = (e) => {
    setInputValue(e.target.value);
  };
 
  const handleButtonClick = () => {
   
    const newTableData = [...tableData];
    newTableData.push(inputValue);
   
    setTableData(newTableData);
    setInputValue('');
  };
 
  return (
    <div>
      <input type="text" value={inputValue} onChange={handleInputChange} />
      <button onClick={handleButtonClick}>Add to Table</button>
 
      <table>
        <thead>
          <tr>
            <th>Values</th>
          </tr>
        </thead>
        <tbody>
          {tableData.map((value) => (
            <tr>
              <td>{value}</td>
            </tr>
          ))}
        </tbody>
      </table>
    </div>
  );
};
 
export default Ex1;