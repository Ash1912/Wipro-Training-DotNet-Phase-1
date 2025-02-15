import { useState } from "react";
import Img1 from "./Images/s1.jpg";
import Img2 from "./Images/s2.jpg";
import Img3 from "./Images/s3.jpg";
import Img4 from "./Images/s4.jpg";

export default function ListImages() {
  const [showlist, setImgs] = useState(false);
  const Images = [Img1, Img2, Img3, Img4];

  return (
    <div>
      <button onClick={() => setImgs(!showlist)}>
        {showlist ? "Images are displayed" : "No images in the list"}
      </button>
      {showlist && (
        <ul>
          {Images.map((item, index) => (
            <li key={index}>
              <img src={item} alt={`Image ${index + 1}`} />
            </li>
          ))}
        </ul>
      )}
    </div>
  );
}
