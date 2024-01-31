import logo from './logo.svg';
import './App.css';
import Home from './Home';
import { BrowserRouter,Routes,Route } from 'react-router-dom';
import About from './About';
import Contact from './Contact';
import Courses from './Courses';
import Nopage from './404';
import Layout from './Layout';

function App() {
  return (
    <div className="App">
      <BrowserRouter>
        <Routes>
          <Route path='/' element={<Layout/>}>
            <Route index element={<Home/>}/>
            <Route path='/about' element={<About/>}/>
            <Route path='/contact' element={<Contact/>}/>
            <Route path='/courses' element={<Courses/>}/>
            <Route path='*' element={<Nopage/>}/>
          </Route>
        </Routes>
      </BrowserRouter>
    </div>
  );
}

export default App;
