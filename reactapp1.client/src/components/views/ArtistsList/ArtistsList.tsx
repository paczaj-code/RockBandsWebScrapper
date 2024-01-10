import MainLayout from '../../Layouts/MainLayout';
import { useEffect, useState } from 'react';
import { useParams } from 'react-router-dom';
import { ArtistLinkTypes } from './ArtistLink';
import { ArtistLink } from './ArtistLink';
import Heading from '../../ui/heading';
interface ArtistsListTypes {
  listTitle: string;
  artistListItems: ArtistLinkTypes[];
}

const ArtistsList = () => {
  const [artistsLists, setArtistsLists] = useState<ArtistsListTypes>();

  const { artistlist } = useParams();

  useEffect(() => {
    getArtistsLists(artistlist!);
  }, [artistlist]);

  return (
    <MainLayout>
      {!artistsLists ? (
        <p>Loading</p>
      ) : (
        <>
          <Heading title={artistsLists.listTitle} />

          <div className="flex flex-wrap gap-4 justify-between items-center">
            {artistsLists?.artistListItems.map((item, index) => (
              <ArtistLink
                key={index}
                artistsName={item.artistsName}
                urlSuffix={item.urlSuffix}
              />
            ))}
          </div>
        </>
      )}
    </MainLayout>
  );

  async function getArtistsLists(artistlist: string) {
    const response = await fetch(`/artistlist/${artistlist}`);

    const data = await response.json();
    setArtistsLists(data.result);
  }
};
export default ArtistsList;
