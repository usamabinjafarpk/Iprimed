import React from 'react'
function User(){
    return(
        <>
        <h1>Welcome User</h1>
        </>
    )
}
function Guest(){
    return(
        <h1>Welcome Guest</h1>
    )
}

export default function Login(props) {
  const isLogged=props.isLoggedIn
//   if(isLogged){
//     return <User/>
//   }
//   else{
//     return <Guest/>
//   }
return isLogged? <User/>:<Guest/>
}
