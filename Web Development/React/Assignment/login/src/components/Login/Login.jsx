import React from 'react'
import Main from '../../Utils/LoginForm/LoginForm'
import Header from '../../Utils/Header/Header'
import Footer from '../../Utils/Footer/Footer'
import '../../components/Login/Login.css'
export default function Login() {
  return (
    <div>

    <div className='login-container' >
      <Header/>
      <Main/>
    </div>
      <Footer/>
    </div>

  )
}
