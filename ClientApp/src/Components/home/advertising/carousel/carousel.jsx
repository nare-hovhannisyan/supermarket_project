import React from "react";
import a from "../../../../Resources/images/sliderimages/a.jpg";
import b from "../../../../Resources/images/sliderimages/b.jpg";
import c from "../../../../Resources/images/sliderimages/c.jpg";
import d from "../../../../Resources/images/sliderimages/d.jpg";
import e from "../../../../Resources/images/sliderimages/e.jpg";
import f from "../../../../Resources/images/sliderimages/f.jpg";
import g from "../../../../Resources/images/sliderimages/g.jpg";
import h from "../../../../Resources/images/sliderimages/h.jpg";

import AwesomeSlider from "react-awesome-slider";
import "react-awesome-slider/dist/styles.css";
const Carouselbox = () => {
  return (
    <AwesomeSlider className="images">
      <div data-src={a} />
      <div data-src={b} />
      <div data-src={c} />
      <div data-src={d} />
      <div data-src={e} />
      <div data-src={f} />
      <div data-src={g} />
      <div data-src={h} />
    </AwesomeSlider>
  );
};

export default Carouselbox;
