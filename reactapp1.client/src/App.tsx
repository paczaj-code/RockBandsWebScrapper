import { useNavigate } from 'react-router-dom';
import MainLayout from './components/Layouts/MainLayout';
import { genres } from '../data/genres';
import { Card } from './components/ui/card';

const App = () => {
  const navigate = useNavigate();

  return (
    <MainLayout>
      <h1 className="text-center py-7">Choose genre</h1>
      <div className="flex flex-wrap gap-4 relative justify-center  items-stretch  mx-auto">
        {genres.map((genre) => (
          <Card
            key={genre.url_sufiix}
            onClick={() => navigate(`/list/${genre.url_sufiix}`)}
            className={` flex justify-center items-center  cursor-pointer py-7 px-4 
            bg-gray-700 text-gray-300
        w-1/4  text-xl hover:bg-sky-800 transition-all duration-500
        font-bold [text-shadow:1px_1px_2px_rgba(0,0,0,0.5)] text-center border-slate-700 border-dashed
        rounded-lg shadow-[0_0px_33px_-13px_black_inset,0_1px_1px_black] hover:text-slate-100 `}
          >
            <p>{genre.name}</p>
          </Card>
        ))}
      </div>
    </MainLayout>
  );
};

export default App;
