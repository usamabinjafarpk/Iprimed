import Demo2 from './Demo2';
import Demo1 from './Demo1';
import Demo3 from './Demo3';
import Demo4 from './Demo4';
import './App.css'
import Demo5 from './Demo5';
import Demo6 from './Demo6';
import Demo7 from './Demo7';

function App() {
  let cities=["Tvm","Kochi"]
  return (
    <div className="App">
      {/* <Demo1/>
      <hr/>
      <Demo2/>
      <Demo3/> */}
      {/* <Demo4/> */}
      {/* <Demo5/>
      <Demo6/> */}
      <Demo7 cities={["Delhi","Mumbai"]}/>
      <hr/>
      <Demo7 cities={cities}/>
    </div>
  );
}

export default App;
