import React from 'react'

export default function Main() {
  return (
    <div className="container mt-5 " style={{ maxWidth: '400px' }}>
      <form>
        <div className="mb-3">
          <label htmlFor="username" className="form-label text-light">
            Username
          </label>
          <input type="text" className="form-control" id="username" required/>
        </div>
        <div className="mb-3">
          <label htmlFor="password" className="form-label text-light">
            Password
          </label>
          <input
            type="password"
            className="form-control"
            id="password"
            
            required
          />
        </div>
        <button type="submit" className="btn btn-primary">
          Login
        </button>
      </form>
    </div>
  )
}
