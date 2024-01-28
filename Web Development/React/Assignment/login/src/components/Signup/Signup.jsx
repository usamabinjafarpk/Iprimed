import React from 'react'
import Footer from '../../Utils/Footer/Footer'
import Header from '../../Utils/Header/Header'
import Signupform from '../../Utils/SignupForm/Signupform'

export default function Signup() {
  return (
    <div>
        <div className='login-container' >
      <Header/>
      <Signupform/>
    </div>
    <Footer/>
    </div>
  )
}
