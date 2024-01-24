import logo from './logo.svg';
import './App.css';
import Add from './components/Add';
import Blogs from './components/Blogs';
import { Outlet, Link, NavLink, Router, useRoutes } from "react-router-dom";
import { BrowserRouter, Routes, Route } from "react-router-dom";

function App() {
  const router=useRoutes()
  return (
    <div className="App">
      {/* <Add/> */}
      {/* <Link to="/blogs">Blogs</Link> */}
      <button onClick={router.push()}>aa</button>
    </div>
  );
}

export default App;
