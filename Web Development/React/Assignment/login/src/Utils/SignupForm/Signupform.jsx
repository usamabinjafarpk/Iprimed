import React from 'react'

export default function Signupform() {
  return (
    <div className="container mt-5" style={{ maxWidth: '400px' }}>
      <form>
        <div className="mb-3">
          <label htmlFor="username" className="form-label text-light">
            Username
          </label>
          <input
            type="text"
            className="form-control"
            id="username"
            required
          />
        </div>
        <div className="mb-3">
          <label htmlFor="email" className="form-label text-light">
            Email
          </label>
          <input
            type="email"
            className="form-control"
            id="email"
            required
          />
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
        <div className="mb-3">
          <label htmlFor="password" className="form-label text-light">
            Confirm Password
          </label>
          <input
            type="password"
            className="form-control"
            id="password"
            required
          />
        </div>
        <button type="submit" className="btn btn-primary">
          Sign Up
        </button>
      </form>
    </div>
  )
}
