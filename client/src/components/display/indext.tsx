import React from "react";

const DisplayVideo = () => {
  return (
    <div className="w-3/5 mx-auto my-16">
      <iframe
        width="100%"
        height="386"
        src="https://www.youtube.com/embed/ferhOYx1NMo"
        title="The OFFICIAL Shopify Tutorial - The COMPLETE GUIDE"
        frameBorder="0"
        allow="accelerometer; autoplay; clipboard-write; encrypted-media; gyroscope; picture-in-picture; web-share"
        referrerPolicy="strict-origin-when-cross-origin"
        allowFullScreen
      ></iframe>
    </div>
  );
};

export default DisplayVideo;
