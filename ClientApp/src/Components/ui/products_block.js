import React from "react";

//Api in firabase wasnt updated > date undefined
const ProductsBlock = ({ ...props }) => {
  console.log(props);

  return (
    <div className="product_block">
      <div className="product_wrapper">
        <div className="product_name">{props.product.name}</div>
      </div>
    </div>
  );
};

export default ProductsBlock;
