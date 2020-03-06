import React from "react";
import { SupMarketLogo } from "../ui/icons";

const Footer = () => {
  return (
    <footer className="bck_blue">
      <div className="footer_logo">
        {
          <SupMarketLogo
            width="80px"
            height="65px"
            link={true}
            linkTo="/"
            borderRadius="1px"
            margin = "5px"
          />
        }
      </div>
      <div className="footer_discl">
        <span>Online Supermarket 2020.All rights reserved.</span>
      </div>
    </footer>
  );
};

export default Footer;
