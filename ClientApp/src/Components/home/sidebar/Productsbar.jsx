import React, { Component } from "react";
import ProductsBlock from "../../ui/products_block";
import Slide from "react-reveal/Slide";

class ProductsBlocks extends Component {
  state = {
    products: []
  };

  componentDidMount() {
    //  const data = []
    // //connect with sql database
    // fetch("https://")
    // .then(response => {
    //   if (!response.ok) throw Error(response.statusText);
    //   return response.json();
    // })
    // .then(data => console.log("data", data))
    // .catch(error => {
    //   console.log("error", error);
    // });
    //     // console.log(matches);
    //     this.setState({
    //         products: data
    //     })
    //  })
  }
  showProducts = products =>
    products
      ? products.map(product => (
          <Slide bottom key={product.id}>
            <div className="productbox">
              <div className="productitem">
                <ProductsBlock product={product} />
              </div>
            </div>
          </Slide>
        ))
      : null;
  render() {
    return (
      <div className="home_matches">
        {this.showProducts(this.state.matches)}
      </div>
    );
  }
}

export default ProductsBlocks;
