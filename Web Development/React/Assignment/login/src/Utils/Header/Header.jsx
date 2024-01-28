import React from 'react'
import { Link } from 'react-router-dom'
export default function Header() {
  return (
    <header className="navbar navbar-expand-lg navbar-light bg-black text-light">
    <div className="container">
      <div className="navbar-brand text-light">ABC</div>
      <div className="navbar-collapse justify-content-end">
        <ul className="navbar-nav ">
          <li className="nav-item ">
            <a className="nav-link text-light" href="#login">
              Login
            </a>
          </li>
          <li className="nav-item">
            <a className="nav-link text-light" href="#signup">
              Signup
            </a>
          </li>
        </ul>
      </div>
    </div>
  </header>
  )
}
