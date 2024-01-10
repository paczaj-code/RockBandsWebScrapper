import React from 'react';

interface HeadingTypes {
  title: string;
}

const Heading: React.FC<HeadingTypes> = ({ title }) => {
  return (
    <>
      <h3
        className="text-4xl pt-3 font-bold"
        dangerouslySetInnerHTML={{ __html: title }}
      ></h3>
      <hr className="border border-y-cyan-700/90 border-dashed mb-5" />
    </>
  );
};

export default Heading;
