import ReactDOM from 'react-dom/client';
import App from './App.tsx';
import { Route } from 'react-router-dom';
import { BrowserRouter, Routes } from 'react-router-dom';
import ArtistsList from './components/views/ArtistsList/ArtistsList.tsx';
import ArtistDetails from './components/views/ArtistDetails/ArtistDetails.tsx';
import './index.output.css';

ReactDOM.createRoot(document.getElementById('root')!).render(
  // <React.StrictMode>
  <BrowserRouter>
    <Routes>
      <Route path="/" element={<App />} />
      <Route path="/list/:artistlist" element={<ArtistsList />} />
      <Route path="/details/:artistname" element={<ArtistDetails />} />
    </Routes>
  </BrowserRouter>
  // </React.StrictMode>
);
