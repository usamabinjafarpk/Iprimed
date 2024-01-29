import logo from './logo.svg';
import './App.css';
import Login from './Demo1';
import Garage from './Garage';
import MailBox from './MailBox';
import { useState } from 'react';

function App() {
  const [first, setfirst] = useState(null)
  // let cars=["BMW","Benz"]
  // let cars=[]
  return (
    <div className="App">
      {/* <Login isLoggedIn={true}/>
      <hr/>
      <Login isLoggedIn={false}/> */}
      {/* <Garage cars={cars}/> */}
      {/* <MailBox unReadMsg='100'/> */}
      <button onClick={()=>setfirst(true)}>User</button>
      <button onClick={()=>setfirst(false)}>Guest</button>
      {first!=null && <Login isLoggedIn={first}/>}
      
    </div>
  );
}

export default App;
