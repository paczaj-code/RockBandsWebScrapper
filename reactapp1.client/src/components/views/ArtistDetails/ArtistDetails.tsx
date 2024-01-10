import { useEffect, useState } from 'react';
import MainLayout from '../../Layouts/MainLayout';
import { useParams } from 'react-router-dom';
import Heading from '../../ui/heading';
import { Button } from '../../ui/button';

interface ArtistDetailsTypes {
  name: string;
  description: string;
  infoTable: string;
}

interface ArtistImageType {
  image: string;
}
interface ArtistImagesType {
  result: ArtistImageType[];
}

const ArtistDetails: React.FC<ArtistDetailsTypes> = () => {
  const [showImages, setShowImage] = useState<boolean>(false);
  const [artistDetails, setArtistDetails] = useState<ArtistDetailsTypes>();
  const [artistImages, setArtistImages] = useState<ArtistImagesType>();
  const { artistname } = useParams();

  useEffect(() => {
    !artistDetails && getArtistDetails(artistname!);
  }, [artistDetails, artistname]);

  useEffect(() => {
    showImages && !artistImages && getArtistImages(artistname!);
  }, [artistImages, artistname, showImages]);

  return (
    <MainLayout>
      {artistDetails && (
        <>
          <Heading title={artistDetails.name!} />
          <Button onClick={() => setShowImage(false)}>Decription</Button>
          <Button onClick={() => setShowImage(true)} className="ml-3">
            Images
          </Button>
          <div className="flex gap-7 items-start mt-4">
            <div
              className={`artist_details ${showImages && 'hidden'}`}
              dangerouslySetInnerHTML={{ __html: artistDetails.description }}
            ></div>
            <div className={`flex-1 ${!showImages && 'hidden'}`}>
              <div className="flex gap-4 flex-wrap items-center justify-center">
                {artistImages &&
                  artistImages.result.map((image) => {
                    return (
                      <div
                        className="overflow-hidden rounded-md shadow-[0_2px_3px_black] border border-sky-100/40 "
                        dangerouslySetInnerHTML={{
                          __html: image.image,
                        }}
                      ></div>
                    );
                  })}
              </div>
            </div>
            <div
              className=" min-w-60 max-w-60 bg-gray-900 p-2 rounded-lg shadow-[0_0px_10px_black] overflow-hidden"
              dangerouslySetInnerHTML={{ __html: artistDetails.infoTable }}
            ></div>
          </div>
        </>
      )}
    </MainLayout>
  );

  async function getArtistDetails(artistname: string) {
    const response = await fetch(`/artist/${artistname}`);

    const data = await response.json();
    setArtistDetails(data.result);
  }

  async function getArtistImages(artistname: string) {
    const response = await fetch(`/artistimage/${artistname}`);

    const data = await response.json();
    setArtistImages(data);
  }
};

export default ArtistDetails;
