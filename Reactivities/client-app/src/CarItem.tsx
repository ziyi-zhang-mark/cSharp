import React from "react";
import { ICar } from "./demo";

// define the props which the CarItem component can be received
interface IProps {
  car: ICar;
}

export const CarItem: React.FC<IProps> = ({ car }) => {
  return (
    <div>
      <h1>{car.color}</h1>
    </div>
  );
};
