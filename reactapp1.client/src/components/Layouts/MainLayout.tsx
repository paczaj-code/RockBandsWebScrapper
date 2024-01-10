import React from 'react';

const MainLayout = ({ children }: { children: React.ReactNode }) => {
  return (
    <main className="max-w-screen-lg mx-auto bg-slate-800 min-h-screen px-10 text-gray-200">
      {children}
    </main>
  );
};

export default MainLayout;
