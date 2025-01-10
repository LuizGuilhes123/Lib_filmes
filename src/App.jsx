import { Link } from 'react-router-dom'
import './App.css'

function App() {
  return (
    <div className='App'>
      <nav id="navbar">
        <h2>
          <Link to="/">Movies Lib</Link>
        </h2>
        <Link to="/Mmovie/1">Movie</Link>
        <Link to="/search">Search</Link>
      </nav>
      <h2>Lib Movies</h2>
    </div>
  )
}

export default App
