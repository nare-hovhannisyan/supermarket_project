import React from "react";
import { Link } from "react-router-dom";
import marketlogo from "../../Resources/images/logos/onlineshoppingart.png";

export const SupMarketLogo = props => {
  const template = (
    <div
      className="img_cover"
      style={{
        width: props.width,
        height: props.height,
        borderRadius: props.borderRadius,
        background: `url(${marketlogo}) no-repeat`
      }}
    ></div>
  );

  if (props.link) {
    return (
      <Link to={props.linkTo} className="link_logo">
        {template}
      </Link>
    );
  } else {
    return template;
  }
};
