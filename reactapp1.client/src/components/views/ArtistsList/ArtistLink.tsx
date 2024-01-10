import React from 'react';
import { useNavigate } from 'react-router-dom';

export interface ArtistLinkTypes {
  artistsName: string;
  urlSuffix: string;
}

export const ArtistLink: React.FC<ArtistLinkTypes> = ({
  artistsName,
  urlSuffix,
}) => {
  const navigate = useNavigate();

  return (
    <p
      className="bg-gray-700 text-gray-300 cursor-pointer border border-gray-600/80 px-2 py-1  rounded-lg shadow-[0_0px_13px_-3px_black_inset,0_1px_1px_black] hover:bg-sky-800 transition-all duration-500"
      onClick={() => navigate(`/details/${urlSuffix}`)}
      dangerouslySetInnerHTML={{ __html: artistsName }}
    ></p>
  );
};
